using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC_8.Models;


namespace MVC_8.Data {
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> {
        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Person> People { get; set; } = null!;
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<Country> Countries { get; set; } = null!;
        public DbSet<Language> Languages { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

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

            string adminRoleId = Guid.NewGuid().ToString();
            string userRoleId = Guid.NewGuid().ToString();
            string userId = Guid.NewGuid().ToString();
            modelBuilder.Entity<IdentityRole>().HasData(new {
                Id = adminRoleId,
                Name = "Admin",
                NormalizedName = "ADMIN"
            });
            modelBuilder.Entity<IdentityRole>().HasData(new {
                Id = userRoleId,
                Name = "User",
                NormalizedName = "USER"
            });

            PasswordHasher<ApplicationUser> passwordHasher = new();

            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser {
                Id = userId,
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                FirstName = "Admin",
                LastName = "Admin",
                BirthDate = new DateTime(),
                PasswordHash = passwordHasher.HashPassword(null!, "password")
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> {
                UserId = userId,
                RoleId = adminRoleId
            });

            // Global turn off delete behaviour on foreign keys
            // https://github.com/dotnet/efcore/issues/13366
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}
