using Microsoft.EntityFrameworkCore;
using MVC_8.Data;

namespace MVC_8.Models {
    public class DataStoreCity : DataStoreItem<City> {
        public DataStoreCity(ApplicationDbContext db, DbSet<City> ds) : base(db, ds) { }

        protected override void CheckBeforeDelete(City item) {
            int nRefernces = Db.People.Where(x => x.CityId == item.Id).Count();
            if (nRefernces > 0) {
                throw new InfoException("The city can't be removed, because there are people in it");
            }
        }
    }
}
