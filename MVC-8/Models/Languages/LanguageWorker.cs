using MVC_8.Data;

namespace MVC_8.Models
{
    public class LanguageWorker
    {
        private ApplicationDbContext DbContext { get; set; } = null!;
        private DataStoreItem<Language> Ds { get; set; } = null!;
        private EntityConst Entity { get; set; } = Const.Language;

        public LanguageWorker(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
            Ds = new DataStoreLanguage(dbContext, dbContext.Languages);
        }

        // =======================================
        // Get List
        // =======================================

        public List<Language> GetItemsList(string filter)
        {
            List<Language> items = Ds.GetTypedItemsFiltered(filter);
            foreach (Language item in items)
                foreach (Person person in item.People)
                    person.Languages = new();
            return items;
        }

        public LanguageListViewModel GetList(string filter)
        {
            int nTotal = Ds.GetNumberOfItems();
            List<EntityItem> items = Ds.GetItemsFiltered(filter);
            LanguageListViewModel model = new();
            model.AddData(items, nTotal, filter);
            return model;
        }

        // =======================================
        // Get Item
        // =======================================

        public LanguageViewModel GetItem(int id)
        {
            string errorMessage = "";
            Language item;
            try
            {
                item = id != 0 ? Ds.GetItemById(id) : new();
            }
            catch (DataStore.ItemNotFoundException)
            {
                item = new();
                errorMessage = $"{Entity.Name} {id} not found";
            }

            LanguageViewModel model = new(item);
            model.AddFail(errorMessage);
            return model;
        }

        // =======================================
        // Add Item
        // =======================================

        public LanguageViewModel AddItem(LanguageViewModel input)
        {
            Language item = input.GetItem();
            item = Ds.AddItem(item);

            LanguageViewModel model = new(item);
            model.AddSuccess($"{Entity.Name} {item.Id} added");
            return model;
        }

        // =======================================
        // Update Item
        // =======================================


        public LanguageViewModel UpdateItem(LanguageViewModel input)
        {
            Language? item = DbContext.Languages.FirstOrDefault(item => item.Id == input.Id);
            if (item == null)
                throw new InfoException($"{Entity.Name} {input.Id} not found");

            item.Name = input.Name;
            Ds.SaveChanges();

            item.People = new();
            LanguageViewModel model = new(item);
            model.AddSuccess($"{Entity.Name} {item.Id} updated");
            return model;
        }

        // =======================================
        // Delete Item
        // =======================================

        public SharedViewModel DeleteItem(int id)
        {

            Language? item = DbContext.Languages.FirstOrDefault(item => item.Id == id);
            if (item == null)
                return new();

            Ds.DeleteItem(id);
            return new();
        }
    }
}
