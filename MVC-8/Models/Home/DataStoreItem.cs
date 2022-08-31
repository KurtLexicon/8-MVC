using Microsoft.EntityFrameworkCore;
using MVC_8.Data;
using System.Linq;

namespace MVC_8.Models.Home {
    public class DataStoreItem<TItem> : DataStore
        where TItem : EntityItem, new()
        {

        private DbSet<TItem> DbSet { get; set; }
        public DataStoreItem(ApplicationDbContext dbContext, DbSet<TItem> dbSet) :base(dbContext) {
            DbSet = dbSet;
        }

        public TItem GetItemById(int id) {
            TItem? item = DbSet
                .FirstOrDefault(item => item.Id == id);
            if (item == null) throw new ItemNotFoundException();
            return item;
        }

        public TItem GetItemById (DbSet<TItem> dbSet, int id){
            TItem? item = dbSet
                .FirstOrDefault(item => item.Id == id);
            if (item == null) throw new ItemNotFoundException();
            return item;
        }


        public int GetNumberOfItems() {
            return DbSet.Count();
        }

        public TItem AddItem(TItem item) {
            DbSet.Add(item);
            Db.SaveChanges();
            return item;
        }

        public TItem UpdateItem(ItemInputViewModel input) {
            TItem item = GetItemById(input.Id);
            item.UpdateFromInput(this, input);
            Db.SaveChanges();
            return item;
        }

        public void DeleteItem(int id) {
            TItem item = GetItemById(id);
            DbSet.Remove(item);
            try {
                Db.SaveChanges();
            } catch(DbUpdateException) {
                // Most probably this is due to existing referncing objects
                // TODO: Check references before trying to delete
                throw new InfoException("The item can't be removed, because of referencing objects");
            }
        }

        virtual public List<TItem> GetItemsFiltered(string filter) {
            var items = DbSet;
            var filtered = string.IsNullOrEmpty(filter) ?
                items :
                items.Where(p => p.Name.Contains(filter));
            return filtered.ToList();
        }
    }
}
