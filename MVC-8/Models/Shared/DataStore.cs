using Microsoft.EntityFrameworkCore;
using MVC_8.Data;

namespace MVC_8.Models.Home {
    public class DataStore {

        public class ItemNotFoundException : Exception { };

        protected ApplicationDbContext Db { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Language> Languages { get; set; }

        public DataStore(ApplicationDbContext dbContext) {
            Db = dbContext;
            People = Db.People;
            Cities = Db.Cities;
            Countries = Db.Countries;
            Languages = Db.Languages;
        }

        public TItem GetItemById<TItem>(DbSet<TItem> dbSet, int id)
            where TItem : EntityItem, new() {
            if (id == 0) return new();
            TItem? item = dbSet.FirstOrDefault(item => item.Id == id);
            if (item == null) throw new ItemNotFoundException();
            return item;
        }

        public bool ExistsId<TItem>(DbSet<TItem> dbSet, int id)
            where TItem : EntityItem {
            TItem? item = dbSet.FirstOrDefault(item => item.Id == id);
            return item != null;
        }

        public List<TItem> GetItemsByIds<TItem>(DbSet<TItem> dbSet, List<int> ids)
            where TItem : EntityItem {
            if (ids.Count == 0) return new();
            List<TItem> items = dbSet.Where(item => ids.Contains(item.Id)).ToList();
            return items;
        }
    }
}
