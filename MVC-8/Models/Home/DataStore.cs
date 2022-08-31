using Microsoft.EntityFrameworkCore;
using MVC_8.Data;
using System.Linq;

namespace MVC_8.Models.Home {
    public class DataStore {

        public class ItemNotFoundException : Exception { };
        public class InfoException : Exception { public InfoException(string message) : base(message) { } };

        protected ApplicationDbContext Db { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }

        public DataStore(ApplicationDbContext dbContext) {
            Db = dbContext;
            People = Db.People;
            Cities = Db.Cities;
            Countries = Db.Countries;
        }

        public TItem GetItemById<TItem>(DbSet<TItem> dbSet, int id)
            where TItem : EntityItem, new() {
            if(id == 0) return new();
            TItem? item = dbSet
                .FirstOrDefault(item => item.Id == id);
            if (item == null) throw new ItemNotFoundException();
            return item;
        }
    }
}
