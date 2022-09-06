using Microsoft.EntityFrameworkCore;
using MVC_8.Data;

namespace MVC_8.Models.Home {
    public class DataStoreCountry: DataStoreItem<Country> {
        public DataStoreCountry(ApplicationDbContext db, DbSet<Country> ds) : base(db, ds) { }

        override public void DeleteItem(int id) {
            Country item = GetItemById(id);
            CheckReferencesOnDelete(item);
            DbSet.Remove(item);
            Db.SaveChanges();
        }

        private void CheckReferencesOnDelete(Country item) {
            int nRefernces = Db.Cities.Where(x => x.CountryId == item.Id).Count();
            if (nRefernces > 0) {
                throw new InfoException("The country can't be removed, because there are cities in it");
            }
        }
    }
}
