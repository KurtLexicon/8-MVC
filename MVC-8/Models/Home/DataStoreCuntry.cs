using Microsoft.EntityFrameworkCore;
using MVC_8.Data;

namespace MVC_8.Models.Home {
    public class DataStoreCuntry: DataStoreItem<Country> {
        public DataStoreCuntry(ApplicationDbContext db, DbSet<Country> ds) : base(db, ds) { }

        // TODO : Add Country-specific database code here
    }
}
