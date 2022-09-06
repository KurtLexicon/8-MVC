using Microsoft.EntityFrameworkCore;
using MVC_8.Models.Home;
using MVC_8.Models;

namespace MVC_8.Data {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Person> People { get; set; } = null!;
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<Country> Countries { get; set; } = null!;
        public DbSet<Language> Languages { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            List<Language> languages = InitData.SeedLanguages();
            modelBuilder.Entity<Language>().HasData(languages.ToArray());

            List<Country> countries = InitData.SeedCountries();
            modelBuilder.Entity<Country>().HasData(countries.ToArray());

            List<City> cities = InitData.SeedCities(countries);
            modelBuilder.Entity<City>().HasData(cities.ToArray());

            List<Person> persons = InitData.SeedPersons(cities, 25);
            modelBuilder.Entity<Person>().HasData(persons.ToArray());

            InitData.PersonLanguage[] PersonLanguages = InitData.SeedPersonLanguages(persons, languages);

            foreach (InitData.PersonLanguage pl in PersonLanguages) {
                modelBuilder.Entity<Person>()
                    .HasMany(p => p.Languages)
                    .WithMany(l => l.People)
                    .UsingEntity(x => x.HasData(new { pl.PeopleId, pl.LanguagesId }));
            }

            modelBuilder.Entity<Person>().Navigation(x => x.City).AutoInclude();
            modelBuilder.Entity<City>().Navigation(x => x.Country).AutoInclude();
            modelBuilder.Entity<Person>().Navigation(x => x.Languages).AutoInclude();

            // Global turn off delete behaviour on foreign keys
            // https://github.com/dotnet/efcore/issues/13366
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}
