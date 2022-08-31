using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace MVC_8.Models.Home {
    public class Country : EntityItem {

        // Constants

        public const string _entityCode = "Country";
        public const string _entityName = "Country";
        public const string _entitiesName = "Countries";
        public const string _viewName = "PvDetailCountry";
        static readonly string[] _rowHeaders = { "Id", "Name" };
        public static readonly Color _color = Color.FromArgb(255, 128, 128);

        // Properties (Other than Id & Name)

        public List<City> Cities { get; set; } = new();

        // Constructors

        public Country() : base() { }
        public Country(int id, string name) : base(id, name) { }

        // Override Methods

        public override Color GetColor() {
            return _color;
        }

        override public string GetPartialViewName() {
            return _viewName;
        }

        override public string[] GetRowValues() {
            return new string[] { Id.ToString(), Name };
        }

        override public string GetEntityCode() { return _entityCode; }

        public override ItemInputViewModel GetItemInputViewModel(DataStore ds) {
            return new InputViewModel(this);
        }

        public override ItemListViewModel GetItemListViewModel(List<EntityItem> items, int totalItems, string filter) {
            return new ListViewModel(items, totalItems, filter);
        }

        public override ItemRowViewModel GetItemRowViewModel() {
            return new RowViewModel(this);
        }

        public override Country UpdateFromInput(DataStore db, ItemInputViewModel itemInput) {
            InputViewModel input = (InputViewModel)itemInput;
            Name = input.Name;
            return this;
        }

        // OverridesClasses (ItemListViewModel, ItemRowViewModel, ItemInputViewModel)

        public class ListViewModel : ItemListViewModel {
            override public string EntityCode { get; } = _entityCode;

            public ListViewModel(List<EntityItem> items, int totalCount, string filter) : base(
                entityName: _entityName,
                entitiesName: _entitiesName,
                totalCount: totalCount,
                filter: filter,
                headers: _rowHeaders,
                itemRows: items.Select(item => item.GetItemRowViewModel()).ToList()
            ) { }
        }

        public class RowViewModel : ItemRowViewModel {
            public RowViewModel(EntityItem item) : base(item) { }
            public override string EntityCode { get; } = _entityCode.ToString();
        }

        public class InputViewModel : ItemInputViewModel {

            // Properties (other than Id & Name)

            // Constructor
            public InputViewModel() : base(_entityCode) { }

            public InputViewModel(Country country) : base(country) { }

            // Override Methods

            public override Country GetItem(DataStore ds, bool getReferencedObjects = true) {
                return new() {
                    Id = Id,
                    Name = Name
                };
            }
        }

        public class Seed : Country { 
            public Seed(Country country) {
                Id = country.Id;
                Name = country.Name;
            }
        }
    }
}
