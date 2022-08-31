
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_8.Data;
using System.Drawing;

namespace MVC_8.Models.Home {
    abstract public class EntityItem {

        // Properties

        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";

        // Constructors

        protected EntityItem() { }
        protected EntityItem(int id, string name) {
            Id = id;
            Name = name;
        }

        protected EntityItem(ItemInputViewModel input) {
            Id = input.Id;
            Name = input.Name;
        }

        // Abstract Methods

        abstract public string GetEntityCode();
        abstract public string GetPartialViewName();

        abstract public ItemInputViewModel GetItemInputViewModel(DataStore ds);
        abstract public ItemListViewModel GetItemListViewModel(List<EntityItem> items, int totalItems, string filter);
        abstract public ItemRowViewModel GetItemRowViewModel();

        abstract public string[] GetRowValues();
        abstract public EntityItem UpdateFromInput(DataStore db, ItemInputViewModel input);
        abstract public Color GetColor();
    }

}
