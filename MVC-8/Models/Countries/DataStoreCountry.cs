using Microsoft.EntityFrameworkCore;
using MVC_8.Data;

namespace MVC_8.Models {
    public class DataStoreCountry : DataStoreItem<Country> {
        public DataStoreCountry(ApplicationDbContext db, DbSet<Country> ds) : base(db, ds) { }

        protected override void CheckBeforeDelete(Country item) {
            int nRefernces = Db.Cities.Where(x => x.CountryId == item.Id).Count();
            if (nRefernces > 0) {
                throw new InfoException("The country can't be removed, because there are cities in it");
            }
        }
    }
}
