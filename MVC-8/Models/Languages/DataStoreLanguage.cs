using Microsoft.EntityFrameworkCore;
using MVC_8.Data;

namespace MVC_8.Models {
    public class DataStoreLanguage : DataStoreItem<Language> {
        public DataStoreLanguage(ApplicationDbContext db, DbSet<Language> ds) : base(db, ds) { }

        override public void DeleteItem(int id) {
            Language? item = DbSet.Include("People").FirstOrDefault(item => item.Id == id);
            if (item == null) return; // Item already deleted, just let it pass
            item.People.Clear();
            Db.SaveChanges();
            DbSet.Remove(item);
            Db.SaveChanges();
        }
    }
}
