using Microsoft.EntityFrameworkCore;
using MVC_8.Data;

namespace MVC_8.Models.Home {
    public class DataStoreCity: DataStoreItem<City> {
        public DataStoreCity(ApplicationDbContext db, DbSet<City> ds) : base(db, ds) { }

        override public void DeleteItem(int id) {
            City item = GetItemById(id);
            CheckReferencesOnDelete(item);
            DbSet.Remove(item);
            Db.SaveChanges();
        }

        private void CheckReferencesOnDelete(City item) {
            int nRefernces = Db.People.Where(x => x.CityId == item.Id).Count();
            if (nRefernces > 0) {
                throw new InfoException("The city can't be removed, because there are people in it");
            }
        }
    }
}
