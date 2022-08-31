using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_8.Data;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace MVC_8.Models.Home {
    public class Person : EntityItem {
        // Constants

        public const string _entityCode = "Person";
        public const string _entityName = "Person";
        public const string _entitiesName = "People";
        public const bool _canCreateRandom = true;
        public const string _viewName = "PvDetailPerson";
        static readonly string[] _rowHeaders = { "Id", "Name", "Phone", "City" };
        public static readonly Color _color = Color.FromArgb(255, 128, 128);

        // Properties

        public City City { get; set; }
        public int CityId { get; set; }
        public string Phone { get; set; } = "";

        // Constructors

        public Person() : base() { City = new(); }

        // Methods

        public Person Seed() {
            Person person = (Person)this.MemberwiseClone();
            person.CityId = person.City.Id;
            person.City = null!;
            return person;
        }

        // Override Methods

        public override Color GetColor() {
            return _color;
        }

        override public string GetPartialViewName() {
            return _viewName;
        }

        override public string[] GetRowValues() {
            return new string[] { Id.ToString(), Name, Phone, City.Name };
        }

        override public string GetEntityCode() { return _entityCode; }

        public override ItemInputViewModel GetItemInputViewModel(DataStore ds) {
            return new InputViewModel(this, ds.Cities);
        }

        public override ItemListViewModel GetItemListViewModel(List<EntityItem> items, int totalItems, string filter) {
            return new ListViewModel(items, totalItems, filter);
        }

        public override ItemRowViewModel GetItemRowViewModel() {
            return new RowViewModel(this);
        }

        public override Person UpdateFromInput(DataStore db, ItemInputViewModel itemInput) {
            InputViewModel input = (InputViewModel)itemInput;
            Name = input.Name;
            Phone = input.Phone;
            City = db.GetItemById<City>(db.Cities, input.CityId) ?? new City();
            CityId = input.CityId;
            return this;
        }


        // OverridesClasses (ItemListViewModel, ItemRowViewModel, ItemInputViewModel)

        public class ListViewModel : ItemListViewModel {
            override public string EntityCode { get; } = _entityCode;

            public ListViewModel(List<EntityItem> items, int totalCount, string filter) : base(
                entityName: _entityName,
                entitiesName: _entitiesName,
                headers: _rowHeaders,
                totalCount: totalCount,
                filter: filter,
                itemRows: items.Select(item => item.GetItemRowViewModel()).ToList(),
                canCreateRandom: true
            ) { }
        }

        public class RowViewModel : ItemRowViewModel {
            public RowViewModel(EntityItem item) : base(item) { }
            public override string EntityCode { get; } = _entityCode.ToString();
        }

        public class InputViewModel : ItemInputViewModel {
            DbSet<City>? _cities;

            // Properties(other than Id & Name)

            [Display(Name = "City")]
            [Required]
            public int CityId { get; set; } = 0;

            [Display(Name = "Phone Number")]
            // Format "+DD-DD DD DD", with "+" and "-" and blanks optional, minimum 3 digits after dash
            [RegularExpression(@"^[\+]?(\d+\s*\-)?(?:\d[\s]*){3,}$", ErrorMessage = "Invalid phone number")]
            public string Phone { get; set; } = "";

            // Constructors

            public InputViewModel() : base(_entityCode) { }

            public InputViewModel(Person item, DbSet<City> cities) : base(item) {
                _cities = cities;
                Phone = item.Phone;
                CityId = item.City.Id;
            }

            // Methods
            public SelectList SelectCities() {
                SelectList ret;
                if (_cities == null) {
                    ret = new(Enumerable.Empty<SelectListItem>());
                } else {
                    ret = new(_cities, "Id", "Name");
                }
                return ret;
            }

            // Override Methods

            override public void InitViewData(DataStore ds) {
                base.InitViewData(ds);
                _cities = ds.Cities;
            }

            public override Person GetItem(DataStore ds, bool getReferencedObjects = true) {
                Person person = new() {
                    Id = Id,
                    Name = Name,
                    Phone = Phone,
                    CityId = CityId
                };
                try {
                    if (getReferencedObjects)
                        person.City = ds.GetItemById(ds.Cities, CityId);
                }
                catch (DataStore.ItemNotFoundException) {
                    throw new DataStore.InfoException("City can not be found");
                }

                return person;
            }
        }
    }
}
