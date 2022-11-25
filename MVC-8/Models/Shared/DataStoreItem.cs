using Microsoft.EntityFrameworkCore;
using MVC_8.Data;

namespace MVC_8.Models {
    public class DataStoreItem<TItem> : DataStore
        where TItem : EntityItem {

        // Properties

        protected DbSet<TItem> DbSet { get; set; }

        // Constructors

        protected DataStoreItem(ApplicationDbContext dbContext, DbSet<TItem> dbSet) : base(dbContext) {
            DbSet = dbSet;
        }

        // Methods

        virtual public int GetNumberOfItems() {
            return DbSet.Count();
        }

        public TItem GetItemById(int id) {
            TItem? item = DbSet.FirstOrDefault(item => item.Id == id);
            if (item == null) throw new ItemNotFoundException();
            return item;
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
            TItem? item = DbSet.FirstOrDefault(item => item.Id == id);
            if (item == null) return; // Item already deleted? Just let it pass
            CheckBeforeDelete(item);
            DbSet.Remove(item);
            Db.SaveChanges();
        }

        virtual protected void CheckBeforeDelete(TItem item) {
            // Override metod might throw exception
        }

        virtual public List<EntityItem> GetItemsFiltered(string filter)
        {
            List<EntityItem> ret = new();
            ret.AddRange(string.IsNullOrEmpty(filter) ?
                DbSet :
                DbSet.Where(p => p.Name.Contains(filter))
             );
            return ret;
        }

        virtual public List<TItem> GetTypedItemsFiltered(string filter)
        {
            List<TItem> ret = new();
            ret.AddRange(string.IsNullOrEmpty(filter) ?
                DbSet :
                DbSet.Where(p => p.Name.Contains(filter))
             );
            return ret;
        }
    }
}
