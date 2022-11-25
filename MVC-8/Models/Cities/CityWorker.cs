using MVC_8.Data;

namespace MVC_8.Models
{
    public class CityWorker
    {
        private ApplicationDbContext DbContext { get; set; } = null!;
        private DataStoreItem<City> Ds { get; set; } = null!;
        private EntityConst Entity { get; set; } = Const.City;

        public CityWorker(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
            Ds = new DataStoreCity(dbContext, dbContext.Cities);
        }

        // =======================================
        // Get List
        // =======================================

        public List<City> GetItemsList(string filter)
        {
            List<City> items = Ds.GetTypedItemsFiltered(filter);
            foreach (City item in items)
                item.Country.Cities = new();
            return items;
        }

        public CityListViewModel GetList(string filter)
        {
            int nTotal = Ds.GetNumberOfItems();
            List<EntityItem> items = Ds.GetItemsFiltered(filter);
            CityListViewModel model = new();
            model.AddData(items, nTotal, filter);
            return model;
        }

        // =======================================
        // Get Item
        // =======================================

        public CityViewModel GetItem(int id)
        {
            string errorMessage = "";
            City item;
            try
            {
                item = id != 0 ? Ds.GetItemById(id) : new();
            }
            catch (DataStore.ItemNotFoundException)
            {
                item = new();
                errorMessage = $"{Entity.Name} {id} not found";
            }

            CityViewModel model = new(item, Ds.Countries.ToList());
            model.AddFail(errorMessage);
            return model;
        }

        // =======================================
        // Add Item
        // =======================================

        public CityViewModel AddItem(CityViewModel input)
        {
            if (null == DbContext.Countries.FirstOrDefault(country => country.Id == input.CountryId))
            {
                throw new InfoException("The country does not exist");
            }

            City item = input.GetItem();
            item = Ds.AddItem(item);

            CityViewModel model = new(item, Ds.Countries.ToList());
            model.AddSuccess($"{Entity.Name} {item.Id} added");
            return model;
        }

        // =======================================
        // Update Item
        // =======================================


        public CityViewModel UpdateItem(CityViewModel input)
        {
            City? item = DbContext.Cities.FirstOrDefault(item => item.Id == input.Id);
            if (item == null)
                throw new InfoException($"{Entity.Name} {input.Id} not found");

            Country? country = DbContext.Countries.FirstOrDefault(country => country.Id == input.CountryId);
            if (null == country)
                throw new InfoException("The country does not exist");

            item.Name = input.Name;
            item.Country = country;
            item.CountryId = input.CountryId;
            Ds.SaveChanges();

            CityViewModel model = new(item, Ds.Countries.ToList());
            model.AddSuccess($"{Entity.Name} {item.Id} updated");
            return model;
        }

        // =======================================
        // Delete Item
        // =======================================

        public SharedViewModel DeleteItem(int id)
        {
            City? item = DbContext.Cities.FirstOrDefault(item => item.Id == id);
            if (item == null)
                return new();

            CheckBeforeDelete(item);
            Ds.DeleteItem(id);
            return new();
        }

        protected void CheckBeforeDelete(City item)
        {
            if (item.People.Count > 0)
            {
                throw new InfoException("The city can not be deleted because there are people living in it");
            }
        }
    }
}
