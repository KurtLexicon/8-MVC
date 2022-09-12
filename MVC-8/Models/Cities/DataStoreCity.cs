using Microsoft.EntityFrameworkCore;
using MVC_8.Data;
using MVC_8.Models.Shared;

namespace MVC_8.Models.Home {
    public class DataStoreCity : DataStoreItem<City> {
        public DataStoreCity(ApplicationDbContext db, DbSet<City> ds) : base(db, ds) { }

        //override public void DeleteItem(int id) {
        //    City? item = DbSet.FirstOrDefault(item => item.Id == id);
        //    if (item == null) return; // Item already deleted, just let it pass
        //    CheckReferencesOnDelete(item);
        //    DbSet.Remove(item);
        //    Db.SaveChanges();
        //}

        protected override void CheckBeforeDelete(City item) {
            int nRefernces = Db.People.Where(x => x.CityId == item.Id).Count();
            if (nRefernces > 0) {
                throw new InfoException("The city can't be removed, because there are people in it");
            }
        }
    }
}
