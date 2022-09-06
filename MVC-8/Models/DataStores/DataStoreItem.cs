using Microsoft.EntityFrameworkCore;
using MVC_8.Data;
using System.Linq;

namespace MVC_8.Models.Home {
    public class DataStoreItem<TItem> : DataStore
        where TItem : EntityItem, new() {

        protected DbSet<TItem> DbSet { get; set; }


        public DataStoreItem(ApplicationDbContext dbContext, DbSet<TItem> dbSet) : base(dbContext) {
            DbSet = dbSet;
        }

        virtual public TItem GetItemById(int id) {
            TItem? item = DbSet.FirstOrDefault(item => item.Id == id);
            if (item == null) throw new ItemNotFoundException();
            return item;
        }

        virtual public int GetNumberOfItems() {
            return DbSet.Count();
        }

        virtual public TItem AddItem(TItem item) {
            DbSet.Add(item);
            Db.SaveChanges();
            return item;
        }

        virtual public void SaveChanges() {
            Db.SaveChanges();
        }

        virtual public void DeleteItem(int id) {
            TItem item = GetItemById(id);
            DbSet.Remove(item);
            Db.SaveChanges();
        }

        virtual public List<EntityItem> GetItemsFiltered(string filter) {
            List<EntityItem> ret = new();
            ret.AddRange(string.IsNullOrEmpty(filter) ?
                DbSet :
                DbSet.Where(p => p.Name.Contains(filter))
             );
            return ret;
        }
    }
}
