using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_8.Data;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace MVC_8.Models.Home {
    public class City : EntityItem {

        // Constants

        public const string _entityCode = "City";
        public const string _entityName = "City";
        public const string _entitiesName = "Cities";
        public const string _viewName = "PvDetailCity";
        static readonly string[] _rowHeaders = { "Id", "Name", "Country" };
        public static readonly Color _color = Color.FromArgb(128, 128, 255);

        // Properties (Other than Id & Name)

        public int CountryId { get; set; }
        public Country Country { get; set; }
        public List<Person> People { get; set; } = new();


        // Constructors

        public City() : base() { Country = new(); }

        public City(int id, string name, Country country) : base(id, name) {
            Country = country;
            CountryId = country.Id;
        }

        // Methods

        public City Seed() {
            City city = (City)this.MemberwiseClone();
            city.Country = null!;
            return city;
        }

        // Override Methods

        public override Color GetColor() {
            return _color;
        }

        override public string GetPartialViewName() {
            return _viewName;
        }

        override public string[] GetRowValues() {
            return new string[] { Id.ToString(), Name, Country.Name };
        }

        override public string GetEntityCode() { return _entityCode; }

        public override ItemInputViewModel GetItemInputViewModel(DataStore ds) {
            return new InputViewModel(this, ds.Countries);
        }

        public override ItemListViewModel GetItemListViewModel(List<EntityItem> items, int totalItems, string filter) {
            return new ListViewModel(items, totalItems, filter);
        }

        public override ItemRowViewModel GetItemRowViewModel() {
            return new RowViewModel(this);
        }

        public override City UpdateFromInput(DataStore db, ItemInputViewModel itemInput) {
            InputViewModel input = (InputViewModel)itemInput;
            Name = input.Name;
            Country = db.GetItemById<Country>(db.Countries, input.CountryId);
            CountryId = input.CountryId;
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
                itemRows: items.Select(item => item.GetItemRowViewModel()).ToList()
            ) { }
        }

        public class RowViewModel : ItemRowViewModel {
            public RowViewModel(EntityItem item) : base(item) { }
            override public string EntityCode { get; } = _entityCode;
        }

        public class InputViewModel : ItemInputViewModel {
            private DbSet<Country>? _countries;

            // Properties

            [Display(Name = "Country")]
            [Required]
            public int CountryId { get; set; } = 0;

            // Constructors

            public InputViewModel() : base(_entityCode) { }

            public InputViewModel(City item, DbSet<Country> countries) : base(item) {
                CountryId = item.Country.Id;
                _countries = countries;
            }

            // Methods

            public SelectList SelectCountries() {
                return _countries == null
                    ? new(Enumerable.Empty<SelectListItem>())
                    : new(_countries, "Id", "Name");
            }


            // Override Methods

            override public void InitViewData(DataStore ds) {
                base.InitViewData(ds);
                _countries = ds.Countries;
            }

            public override City GetItem(DataStore ds, bool getReferencedObjects = true) {
                City city = new() {
                    Id = Id,
                    Name = Name,
                    CountryId = CountryId
                };
                try {
                    if (getReferencedObjects)
                        city.Country = ds.GetItemById(ds.Countries, CountryId);
                }
                catch (DataStore.ItemNotFoundException) {
                    throw new DataStore.InfoException("Country can not be found");
                }
                return city;

            }
        }
    }
}
