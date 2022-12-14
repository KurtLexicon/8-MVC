// <auto-generated />
using System;
using MVC_8.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC_8.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220914210629_Init-9-4")]
    partial class Init94
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LanguagePerson", b =>
                {
                    b.Property<int>("LanguagesId")
                        .HasColumnType("int");

                    b.Property<int>("PeopleId")
                        .HasColumnType("int");

                    b.HasKey("LanguagesId", "PeopleId");

                    b.HasIndex("PeopleId");

                    b.ToTable("LanguagePerson");

                    b.HasData(
                        new
                        {
                            LanguagesId = 2,
                            PeopleId = 1
                        },
                        new
                        {
                            LanguagesId = 3,
                            PeopleId = 1
                        },
                        new
                        {
                            LanguagesId = 1,
                            PeopleId = 1
                        },
                        new
                        {
                            LanguagesId = 5,
                            PeopleId = 1
                        },
                        new
                        {
                            LanguagesId = 7,
                            PeopleId = 2
                        },
                        new
                        {
                            LanguagesId = 7,
                            PeopleId = 3
                        },
                        new
                        {
                            LanguagesId = 3,
                            PeopleId = 3
                        },
                        new
                        {
                            LanguagesId = 3,
                            PeopleId = 4
                        },
                        new
                        {
                            LanguagesId = 5,
                            PeopleId = 4
                        },
                        new
                        {
                            LanguagesId = 6,
                            PeopleId = 4
                        },
                        new
                        {
                            LanguagesId = 4,
                            PeopleId = 4
                        },
                        new
                        {
                            LanguagesId = 5,
                            PeopleId = 5
                        },
                        new
                        {
                            LanguagesId = 4,
                            PeopleId = 5
                        },
                        new
                        {
                            LanguagesId = 4,
                            PeopleId = 6
                        },
                        new
                        {
                            LanguagesId = 3,
                            PeopleId = 6
                        },
                        new
                        {
                            LanguagesId = 6,
                            PeopleId = 6
                        },
                        new
                        {
                            LanguagesId = 5,
                            PeopleId = 6
                        },
                        new
                        {
                            LanguagesId = 4,
                            PeopleId = 7
                        },
                        new
                        {
                            LanguagesId = 5,
                            PeopleId = 7
                        },
                        new
                        {
                            LanguagesId = 7,
                            PeopleId = 7
                        },
                        new
                        {
                            LanguagesId = 1,
                            PeopleId = 7
                        },
                        new
                        {
                            LanguagesId = 7,
                            PeopleId = 9
                        },
                        new
                        {
                            LanguagesId = 5,
                            PeopleId = 9
                        },
                        new
                        {
                            LanguagesId = 7,
                            PeopleId = 11
                        },
                        new
                        {
                            LanguagesId = 2,
                            PeopleId = 11
                        },
                        new
                        {
                            LanguagesId = 1,
                            PeopleId = 11
                        },
                        new
                        {
                            LanguagesId = 3,
                            PeopleId = 11
                        },
                        new
                        {
                            LanguagesId = 5,
                            PeopleId = 13
                        },
                        new
                        {
                            LanguagesId = 7,
                            PeopleId = 14
                        },
                        new
                        {
                            LanguagesId = 1,
                            PeopleId = 15
                        },
                        new
                        {
                            LanguagesId = 4,
                            PeopleId = 15
                        },
                        new
                        {
                            LanguagesId = 3,
                            PeopleId = 15
                        },
                        new
                        {
                            LanguagesId = 5,
                            PeopleId = 15
                        },
                        new
                        {
                            LanguagesId = 2,
                            PeopleId = 16
                        },
                        new
                        {
                            LanguagesId = 3,
                            PeopleId = 16
                        },
                        new
                        {
                            LanguagesId = 5,
                            PeopleId = 16
                        },
                        new
                        {
                            LanguagesId = 1,
                            PeopleId = 17
                        },
                        new
                        {
                            LanguagesId = 6,
                            PeopleId = 17
                        },
                        new
                        {
                            LanguagesId = 5,
                            PeopleId = 17
                        },
                        new
                        {
                            LanguagesId = 5,
                            PeopleId = 18
                        },
                        new
                        {
                            LanguagesId = 1,
                            PeopleId = 18
                        },
                        new
                        {
                            LanguagesId = 7,
                            PeopleId = 18
                        },
                        new
                        {
                            LanguagesId = 2,
                            PeopleId = 18
                        },
                        new
                        {
                            LanguagesId = 3,
                            PeopleId = 19
                        },
                        new
                        {
                            LanguagesId = 1,
                            PeopleId = 19
                        },
                        new
                        {
                            LanguagesId = 6,
                            PeopleId = 19
                        },
                        new
                        {
                            LanguagesId = 5,
                            PeopleId = 19
                        },
                        new
                        {
                            LanguagesId = 2,
                            PeopleId = 22
                        },
                        new
                        {
                            LanguagesId = 4,
                            PeopleId = 22
                        },
                        new
                        {
                            LanguagesId = 6,
                            PeopleId = 22
                        },
                        new
                        {
                            LanguagesId = 2,
                            PeopleId = 23
                        },
                        new
                        {
                            LanguagesId = 4,
                            PeopleId = 23
                        },
                        new
                        {
                            LanguagesId = 7,
                            PeopleId = 23
                        },
                        new
                        {
                            LanguagesId = 3,
                            PeopleId = 23
                        },
                        new
                        {
                            LanguagesId = 5,
                            PeopleId = 24
                        },
                        new
                        {
                            LanguagesId = 7,
                            PeopleId = 24
                        },
                        new
                        {
                            LanguagesId = 2,
                            PeopleId = 24
                        },
                        new
                        {
                            LanguagesId = 3,
                            PeopleId = 25
                        },
                        new
                        {
                            LanguagesId = 1,
                            PeopleId = 25
                        },
                        new
                        {
                            LanguagesId = 5,
                            PeopleId = 25
                        },
                        new
                        {
                            LanguagesId = 2,
                            PeopleId = 25
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "5d6ba5de-955b-41eb-b3a1-a844f2570555",
                            Name = "Admin"
                        },
                        new
                        {
                            Id = "212ea74e-9002-4c1a-b4ad-c5e1207a3f6e",
                            Name = "User"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "1004f470-054f-447a-97a7-07039562feb6",
                            RoleId = "5d6ba5de-955b-41eb-b3a1-a844f2570555"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MVC_8.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1004f470-054f-447a-97a7-07039562feb6",
                            AccessFailedCount = 0,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "43950fb0-1fe6-43f8-88a8-21928970d4d4",
                            Email = "admin@admin.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEBcc23TtN/lS0Mkxu19QVu8aPxWV7YyfQEbOneObszyDeLMZ5WAb3EwXf44RAb040g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "be2fb879-8f57-44af-a2b9-0964d3bb79b3",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("MVC_8.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            Name = "Axevalla"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 1,
                            Name = "Floby"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 1,
                            Name = "Götene"
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 1,
                            Name = "Hällekis"
                        },
                        new
                        {
                            Id = 5,
                            CountryId = 1,
                            Name = "Källby"
                        },
                        new
                        {
                            Id = 6,
                            CountryId = 1,
                            Name = "Lerdala"
                        },
                        new
                        {
                            Id = 7,
                            CountryId = 1,
                            Name = "Skulltorp"
                        },
                        new
                        {
                            Id = 8,
                            CountryId = 1,
                            Name = "Stenstorp"
                        },
                        new
                        {
                            Id = 9,
                            CountryId = 1,
                            Name = "Tibro"
                        },
                        new
                        {
                            Id = 10,
                            CountryId = 1,
                            Name = "Tidaholm"
                        },
                        new
                        {
                            Id = 11,
                            CountryId = 1,
                            Name = "Töreboda"
                        },
                        new
                        {
                            Id = 12,
                            CountryId = 2,
                            Name = "New York"
                        });
                });

            modelBuilder.Entity("MVC_8.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Skaraborg"
                        },
                        new
                        {
                            Id = 2,
                            Name = "USA"
                        });
                });

            modelBuilder.Entity("MVC_8.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Klingon"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Meänkieli"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Mixtec"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Papiamento"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Swahili"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Volapük"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Väschözzga"
                        });
                });

            modelBuilder.Entity("MVC_8.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 12,
                            Name = "Beda Dahl",
                            Phone = "713480"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 10,
                            Name = "Lisbet Zackow",
                            Phone = "491755"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 12,
                            Name = "Adrian Ålander",
                            Phone = "855214"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 6,
                            Name = "Olle Hjalmarsson",
                            Phone = "930605"
                        },
                        new
                        {
                            Id = 5,
                            CityId = 2,
                            Name = "Adrian Jonsson",
                            Phone = "485295"
                        },
                        new
                        {
                            Id = 6,
                            CityId = 8,
                            Name = "Adrian Sventon",
                            Phone = "327587"
                        },
                        new
                        {
                            Id = 7,
                            CityId = 7,
                            Name = "Olle Erixon",
                            Phone = "560182"
                        },
                        new
                        {
                            Id = 8,
                            CityId = 11,
                            Name = "Åsa Sventon",
                            Phone = "920249"
                        },
                        new
                        {
                            Id = 9,
                            CityId = 9,
                            Name = "Kim Sventon",
                            Phone = "888439"
                        },
                        new
                        {
                            Id = 10,
                            CityId = 3,
                            Name = "Lisbet Hjalmarsson",
                            Phone = "338361"
                        },
                        new
                        {
                            Id = 11,
                            CityId = 5,
                            Name = "Beda Ståhl",
                            Phone = "716302"
                        },
                        new
                        {
                            Id = 12,
                            CityId = 11,
                            Name = "Kim Ivarsson",
                            Phone = "376751"
                        },
                        new
                        {
                            Id = 13,
                            CityId = 10,
                            Name = "Ylva Malmsten",
                            Phone = "929120"
                        },
                        new
                        {
                            Id = 14,
                            CityId = 6,
                            Name = "Ilja Ivarsson",
                            Phone = "973550"
                        },
                        new
                        {
                            Id = 15,
                            CityId = 10,
                            Name = "Olle Zackow",
                            Phone = "179079"
                        },
                        new
                        {
                            Id = 16,
                            CityId = 6,
                            Name = "Osborn Carlsson",
                            Phone = "110108"
                        },
                        new
                        {
                            Id = 17,
                            CityId = 2,
                            Name = "Kalle Krall",
                            Phone = "594745"
                        },
                        new
                        {
                            Id = 18,
                            CityId = 5,
                            Name = "Alva Malmsten",
                            Phone = "520198"
                        },
                        new
                        {
                            Id = 19,
                            CityId = 11,
                            Name = "Lisbet Ålander",
                            Phone = "171623"
                        },
                        new
                        {
                            Id = 20,
                            CityId = 3,
                            Name = "Ture Dahl",
                            Phone = "724403"
                        },
                        new
                        {
                            Id = 21,
                            CityId = 1,
                            Name = "Mika Fahlgren",
                            Phone = "773261"
                        },
                        new
                        {
                            Id = 22,
                            CityId = 8,
                            Name = "Ylva Walker",
                            Phone = "353269"
                        },
                        new
                        {
                            Id = 23,
                            CityId = 11,
                            Name = "Ture Ivarsson",
                            Phone = "303758"
                        },
                        new
                        {
                            Id = 24,
                            CityId = 1,
                            Name = "Lisbet Dahl",
                            Phone = "105257"
                        },
                        new
                        {
                            Id = 25,
                            CityId = 9,
                            Name = "Adrian Bildt",
                            Phone = "623020"
                        });
                });

            modelBuilder.Entity("LanguagePerson", b =>
                {
                    b.HasOne("MVC_8.Models.Language", null)
                        .WithMany()
                        .HasForeignKey("LanguagesId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MVC_8.Models.Person", null)
                        .WithMany()
                        .HasForeignKey("PeopleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MVC_8.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MVC_8.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MVC_8.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MVC_8.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("MVC_8.Models.City", b =>
                {
                    b.HasOne("MVC_8.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("MVC_8.Models.Person", b =>
                {
                    b.HasOne("MVC_8.Models.City", "City")
                        .WithMany("People")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("MVC_8.Models.City", b =>
                {
                    b.Navigation("People");
                });

            modelBuilder.Entity("MVC_8.Models.Country", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
