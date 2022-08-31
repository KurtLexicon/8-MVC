using Microsoft.EntityFrameworkCore;
using MVC_8.Models.Home;

namespace MVC_8.Data {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Person> People { get; set; } = null!;
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<Country> Countries { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            List<Country> countries = InitData.SeedCountries();
            modelBuilder.Entity<Country>().HasData(countries.ToArray());

            List<City> cities = InitData.SeedCities(countries);
            City[] citySeeds = cities.Select(c => c.Seed()).ToArray();
            modelBuilder.Entity<City>().HasData(citySeeds);

            List<Person> persons = InitData.SeedPersons(cities, 5);
            Person[] personSeeds = persons.Select(p => p.Seed()).ToArray();
            modelBuilder.Entity<Person>().HasData(personSeeds);

            modelBuilder.Entity<Person>().Navigation(x => x.City).AutoInclude();
            modelBuilder.Entity<City>().Navigation(x => x.Country).AutoInclude();

            // Global turn off delete behaviour on foreign keys
            // https://github.com/dotnet/efcore/issues/13366
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}
