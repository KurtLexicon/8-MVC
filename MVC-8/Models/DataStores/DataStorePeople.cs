using Microsoft.EntityFrameworkCore;
using MVC_8.Data;

namespace MVC_8.Models.Home {
    public class DataStorePeople: DataStoreItem<Person> {
        public DataStorePeople(ApplicationDbContext dbContext, DbSet<Person> dbSet) : base(dbContext, dbSet) { }

        override public List<EntityItem> GetItemsFiltered(string filter) {
            List<EntityItem> ret = new();
            ret.AddRange(string.IsNullOrEmpty(filter) ?
                DbSet :
                DbSet.Where(p => p.Name.Contains(filter) || p.City.Name.Contains(filter))
             );
            return ret;
        }

        override public void DeleteItem(int id) {
            Person item = GetItemById(id);
            item.Languages.Clear();
            Db.SaveChanges();
            DbSet.Remove(item);
            Db.SaveChanges();
        }
    }
}
