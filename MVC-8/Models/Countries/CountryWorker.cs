using MVC_8.Data;

namespace MVC_8.Models
{
    public class CountryWorker
    {
        private ApplicationDbContext DbContext { get; set; } = null!;
        private DataStoreItem<Country> Ds { get; set; } = null!;
        private EntityConst Entity { get; set; } = Const.Country;

        public CountryWorker(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
            Ds = new DataStoreCountry(dbContext, dbContext.Countries);
        }

        // =======================================
        // Get List
        // =======================================

        public List<Country> GetItemsList(string filter)
        {
            List<Country> items = Ds.GetTypedItemsFiltered(filter);
            foreach (Country item in items)
                item.Cities = new();
            return items;
        }

        public CountryListViewModel GetList(string filter)
        {
            int nTotal = Ds.GetNumberOfItems();
            List<EntityItem> items = Ds.GetItemsFiltered(filter);
            CountryListViewModel model = new();
            model.AddData(items, nTotal, filter);
            return model;
        }

        // =======================================
        // Get Item
        // =======================================

        public CountryViewModel GetItem(int id)
        {
            string errorMessage = "";
            Country item;
            try
            {
                item = id != 0 ? Ds.GetItemById(id) : new();
            }
            catch (DataStore.ItemNotFoundException)
            {
                item = new();
                errorMessage = $"{Entity.Name} {id} not found";
            }

            CountryViewModel model = new(item);
            model.AddFail(errorMessage);
            return model;
        }

        // =======================================
        // Add Item
        // =======================================

        public CountryViewModel AddItem(CountryViewModel input)
        {
            Country item = input.GetItem();
            item = Ds.AddItem(item);

            CountryViewModel model = new(item);
            model.AddSuccess($"{Entity.Name} {item.Id} added");
            return model;
        }

        // =======================================
        // Update Item
        // =======================================


        public CountryViewModel UpdateItem(CountryViewModel input)
        {
            Country? item = DbContext.Countries.FirstOrDefault(item => item.Id == input.Id);
            if (item == null)
                throw new InfoException($"{Entity.Name} {input.Id} not found");

            item.Name = input.Name;
            Ds.SaveChanges();

            item.Cities = new();
            CountryViewModel model = new(item);
            model.AddSuccess($"{Entity.Name} {item.Id} updated");
            return model;
        }

        // =======================================
        // Delete Item
        // =======================================

        public SharedViewModel DeleteItem(int id)
        {
            Country? item = DbContext.Countries.FirstOrDefault(item => item.Id == id);
            if (item == null)
                return new();

            CheckBeforeDelete(item);
            Ds.DeleteItem(id);
            return new();
        }

        protected void CheckBeforeDelete(Country item)
        {
            if (item.Cities.Count > 0)
            {
                throw new InfoException("The country can not be deleted because there are cities in it");
            }
        }
    }
}
