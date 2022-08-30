using Microsoft.EntityFrameworkCore;
using MVC_8.Models.Home;

namespace MVC_8.Data {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext() {

        }

        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options) 
            : base(options){

        }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            for(int id = 1; id <= 5; id++) {
                modelBuilder.Entity<Person>().HasData(RandomData.GetRandomPerson(id));
            }
        }
    }
}
