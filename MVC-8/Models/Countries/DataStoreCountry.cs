using Microsoft.EntityFrameworkCore;
using MVC_8.Data;
using MVC_8.Models.Shared;

namespace MVC_8.Models.Home {
    public class DataStoreCountry : DataStoreItem<Country> {
        public DataStoreCountry(ApplicationDbContext db, DbSet<Country> ds) : base(db, ds) { }

        //override public void DeleteItem(int id) {
        //    Country? item = DbSet.FirstOrDefault(item => item.Id == id);
        //    if (item == null) return; // Item already deleted, just let it pass
        //    CheckBeforeDelete(item);
        //    DbSet.Remove(item);
        //    Db.SaveChanges();
        //}

        protected override void CheckBeforeDelete(Country item) {
            int nRefernces = Db.Cities.Where(x => x.CountryId == item.Id).Count();
            if (nRefernces > 0) {
                throw new InfoException("The country can't be removed, because there are cities in it");
            }
        }
    }
}
