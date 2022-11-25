﻿// <auto-generated />
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
    [Migration("20221117085708_221117-2")]
    partial class _2211172
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
                            LanguagesId = 1,
                            PeopleId = 1
                        },
                        new
                        {
                            LanguagesId = 6,
                            PeopleId = 1
                        },
                        new
                        {
                            LanguagesId = 1,
                            PeopleId = 2
                        },
                        new
                        {
                            LanguagesId = 4,
                            PeopleId = 2
                        },
                        new
                        {
                            LanguagesId = 3,
                            PeopleId = 3
                        },
                        new
                        {
                            LanguagesId = 2,
                            PeopleId = 3
                        },
                        new
                        {
                            LanguagesId = 6,
                            PeopleId = 3
                        },
                        new
                        {
                            LanguagesId = 6,
                            PeopleId = 4
                        },
                        new
                        {
                            LanguagesId = 2,
                            PeopleId = 5
                        },
                        new
                        {
                            LanguagesId = 6,
                            PeopleId = 5
                        },
                        new
                        {
                            LanguagesId = 1,
                            PeopleId = 5
                        },
                        new
                        {
                            LanguagesId = 3,
                            PeopleId = 5
                        },
                        new
                        {
                            LanguagesId = 6,
                            PeopleId = 7
                        },
                        new
                        {
                            LanguagesId = 3,
                            PeopleId = 7
                        },
                        new
                        {
                            LanguagesId = 2,
                            PeopleId = 7
                        },
                        new
                        {
                            LanguagesId = 7,
                            PeopleId = 7
                        },
                        new
                        {
                            LanguagesId = 4,
                            PeopleId = 8
                        },
                        new
                        {
                            LanguagesId = 7,
                            PeopleId = 8
                        },
                        new
                        {
                            LanguagesId = 2,
                            PeopleId = 9
                        },
                        new
                        {
                            LanguagesId = 4,
                            PeopleId = 9
                        },
                        new
                        {
                            LanguagesId = 6,
                            PeopleId = 10
                        },
                        new
                        {
                            LanguagesId = 1,
                            PeopleId = 11
                        },
                        new
                        {
                            LanguagesId = 2,
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
                            PeopleId = 11
                        },
                        new
                        {
                            LanguagesId = 2,
                            PeopleId = 12
                        },
                        new
                        {
                            LanguagesId = 1,
                            PeopleId = 12
                        },
                        new
                        {
                            LanguagesId = 7,
                            PeopleId = 12
                        },
                        new
                        {
                            LanguagesId = 6,
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
                            PeopleId = 14
                        },
                        new
                        {
                            LanguagesId = 5,
                            PeopleId = 16
                        },
                        new
                        {
                            LanguagesId = 6,
                            PeopleId = 16
                        },
                        new
                        {
                            LanguagesId = 4,
                            PeopleId = 16
                        },
                        new
                        {
                            LanguagesId = 7,
                            PeopleId = 16
                        },
                        new
                        {
                            LanguagesId = 3,
                            PeopleId = 19
                        },
                        new
                        {
                            LanguagesId = 3,
                            PeopleId = 20
                        },
                        new
                        {
                            LanguagesId = 6,
                            PeopleId = 20
                        },
                        new
                        {
                            LanguagesId = 2,
                            PeopleId = 21
                        },
                        new
                        {
                            LanguagesId = 5,
                            PeopleId = 21
                        },
                        new
                        {
                            LanguagesId = 3,
                            PeopleId = 21
                        },
                        new
                        {
                            LanguagesId = 2,
                            PeopleId = 22
                        },
                        new
                        {
                            LanguagesId = 7,
                            PeopleId = 22
                        },
                        new
                        {
                            LanguagesId = 1,
                            PeopleId = 22
                        },
                        new
                        {
                            LanguagesId = 6,
                            PeopleId = 22
                        },
                        new
                        {
                            LanguagesId = 3,
                            PeopleId = 23
                        },
                        new
                        {
                            LanguagesId = 4,
                            PeopleId = 25
                        },
                        new
                        {
                            LanguagesId = 2,
                            PeopleId = 25
                        },
                        new
                        {
                            LanguagesId = 3,
                            PeopleId = 25
                        },
                        new
                        {
                            LanguagesId = 5,
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
                            Id = "65323db4-0ca7-483b-af60-65a90ec788af",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "f113ba97-e370-4c47-b3e9-3e5a04487809",
                            Name = "User",
                            NormalizedName = "USER"
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
                            UserId = "1062b699-f2ac-45e3-abbc-3153cec81ac8",
                            RoleId = "65323db4-0ca7-483b-af60-65a90ec788af"
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
                            Id = "1062b699-f2ac-45e3-abbc-3153cec81ac8",
                            AccessFailedCount = 0,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "c73dbe06-684e-4f5e-9a71-fa8aa9a44fe8",
                            Email = "admin@admin.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN@ADMIN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEIM4dyyFgSdUT1AelNuU9anV38CL3nCe1fNJ2pD8Db3bbJo4rutWW6jfu5bPWVpQRQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f182b757-3ccc-4e44-8535-99228f1c591a",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.com"
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
                            CityId = 5,
                            Name = "Olle Bildt",
                            Phone = "669140"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 2,
                            Name = "Dave Walker",
                            Phone = "147139"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 2,
                            Name = "Kalle Lindgren",
                            Phone = "743027"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 9,
                            Name = "Olle Fahlgren",
                            Phone = "280915"
                        },
                        new
                        {
                            Id = 5,
                            CityId = 1,
                            Name = "Beda Ståhl",
                            Phone = "280452"
                        },
                        new
                        {
                            Id = 6,
                            CityId = 5,
                            Name = "Dave Ålander",
                            Phone = "946739"
                        },
                        new
                        {
                            Id = 7,
                            CityId = 12,
                            Name = "Adrian Sventon",
                            Phone = "840031"
                        },
                        new
                        {
                            Id = 8,
                            CityId = 1,
                            Name = "Åsa Dahl",
                            Phone = "426903"
                        },
                        new
                        {
                            Id = 9,
                            CityId = 5,
                            Name = "Alva Sventon",
                            Phone = "457281"
                        },
                        new
                        {
                            Id = 10,
                            CityId = 1,
                            Name = "Ulla Fahlgren",
                            Phone = "368535"
                        },
                        new
                        {
                            Id = 11,
                            CityId = 7,
                            Name = "Nisse Sventon",
                            Phone = "266125"
                        },
                        new
                        {
                            Id = 12,
                            CityId = 6,
                            Name = "Beda Dahl",
                            Phone = "868170"
                        },
                        new
                        {
                            Id = 13,
                            CityId = 10,
                            Name = "Ture Bildt",
                            Phone = "767862"
                        },
                        new
                        {
                            Id = 14,
                            CityId = 6,
                            Name = "Nisse Ivarsson",
                            Phone = "489406"
                        },
                        new
                        {
                            Id = 15,
                            CityId = 7,
                            Name = "Ture Bildt",
                            Phone = "436687"
                        },
                        new
                        {
                            Id = 16,
                            CityId = 10,
                            Name = "Kalle Malmsten",
                            Phone = "504479"
                        },
                        new
                        {
                            Id = 17,
                            CityId = 5,
                            Name = "Ulla Ålander",
                            Phone = "928310"
                        },
                        new
                        {
                            Id = 18,
                            CityId = 12,
                            Name = "Nisse Ålander",
                            Phone = "351721"
                        },
                        new
                        {
                            Id = 19,
                            CityId = 8,
                            Name = "Lisbet Jonsson",
                            Phone = "595372"
                        },
                        new
                        {
                            Id = 20,
                            CityId = 11,
                            Name = "Lotta Malmsten",
                            Phone = "353681"
                        },
                        new
                        {
                            Id = 21,
                            CityId = 12,
                            Name = "Mika Erixon",
                            Phone = "696748"
                        },
                        new
                        {
                            Id = 22,
                            CityId = 11,
                            Name = "Ilja Malmsten",
                            Phone = "608977"
                        },
                        new
                        {
                            Id = 23,
                            CityId = 2,
                            Name = "Nisse Ståhl",
                            Phone = "693290"
                        },
                        new
                        {
                            Id = 24,
                            CityId = 11,
                            Name = "Ilja Erixon",
                            Phone = "481369"
                        },
                        new
                        {
                            Id = 25,
                            CityId = 6,
                            Name = "Alva Fahlgren",
                            Phone = "599424"
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
