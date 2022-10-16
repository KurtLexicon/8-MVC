﻿// <auto-generated />
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
    [Migration("20220912110345_Init-9-3")]
    partial class Init93
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
                            LanguagesId = 3,
                            PeopleId = 1
                        },
                        new
                        {
                            LanguagesId = 2,
                            PeopleId = 1
                        },
                        new
                        {
                            LanguagesId = 6,
                            PeopleId = 3
                        },
                        new
                        {
                            LanguagesId = 5,
                            PeopleId = 3
                        },
                        new
                        {
                            LanguagesId = 4,
                            PeopleId = 3
                        },
                        new
                        {
                            LanguagesId = 7,
                            PeopleId = 4
                        },
                        new
                        {
                            LanguagesId = 2,
                            PeopleId = 5
                        },
                        new
                        {
                            LanguagesId = 5,
                            PeopleId = 5
                        },
                        new
                        {
                            LanguagesId = 6,
                            PeopleId = 5
                        },
                        new
                        {
                            LanguagesId = 5,
                            PeopleId = 6
                        },
                        new
                        {
                            LanguagesId = 3,
                            PeopleId = 7
                        },
                        new
                        {
                            LanguagesId = 7,
                            PeopleId = 7
                        },
                        new
                        {
                            LanguagesId = 6,
                            PeopleId = 7
                        },
                        new
                        {
                            LanguagesId = 5,
                            PeopleId = 8
                        },
                        new
                        {
                            LanguagesId = 7,
                            PeopleId = 8
                        },
                        new
                        {
                            LanguagesId = 4,
                            PeopleId = 10
                        },
                        new
                        {
                            LanguagesId = 7,
                            PeopleId = 10
                        },
                        new
                        {
                            LanguagesId = 6,
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
                            PeopleId = 13
                        },
                        new
                        {
                            LanguagesId = 4,
                            PeopleId = 13
                        },
                        new
                        {
                            LanguagesId = 3,
                            PeopleId = 14
                        },
                        new
                        {
                            LanguagesId = 5,
                            PeopleId = 15
                        },
                        new
                        {
                            LanguagesId = 2,
                            PeopleId = 15
                        },
                        new
                        {
                            LanguagesId = 6,
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
                            LanguagesId = 4,
                            PeopleId = 19
                        },
                        new
                        {
                            LanguagesId = 5,
                            PeopleId = 19
                        },
                        new
                        {
                            LanguagesId = 3,
                            PeopleId = 19
                        },
                        new
                        {
                            LanguagesId = 6,
                            PeopleId = 20
                        },
                        new
                        {
                            LanguagesId = 4,
                            PeopleId = 20
                        },
                        new
                        {
                            LanguagesId = 5,
                            PeopleId = 20
                        },
                        new
                        {
                            LanguagesId = 2,
                            PeopleId = 20
                        },
                        new
                        {
                            LanguagesId = 2,
                            PeopleId = 21
                        },
                        new
                        {
                            LanguagesId = 7,
                            PeopleId = 21
                        },
                        new
                        {
                            LanguagesId = 5,
                            PeopleId = 22
                        },
                        new
                        {
                            LanguagesId = 5,
                            PeopleId = 23
                        },
                        new
                        {
                            LanguagesId = 4,
                            PeopleId = 23
                        },
                        new
                        {
                            LanguagesId = 3,
                            PeopleId = 23
                        },
                        new
                        {
                            LanguagesId = 7,
                            PeopleId = 23
                        },
                        new
                        {
                            LanguagesId = 6,
                            PeopleId = 24
                        },
                        new
                        {
                            LanguagesId = 4,
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
                            PeopleId = 24
                        },
                        new
                        {
                            LanguagesId = 3,
                            PeopleId = 25
                        },
                        new
                        {
                            LanguagesId = 6,
                            PeopleId = 25
                        },
                        new
                        {
                            LanguagesId = 4,
                            PeopleId = 25
                        });
                });

            modelBuilder.Entity("MVC_8.Models.Home.City", b =>
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

            modelBuilder.Entity("MVC_8.Models.Home.Country", b =>
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

            modelBuilder.Entity("MVC_8.Models.Home.Language", b =>
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

            modelBuilder.Entity("MVC_8.Models.Home.Person", b =>
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
                            CityId = 9,
                            Name = "Mika Carlsson",
                            Phone = "956240"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 8,
                            Name = "Dave Lindgren",
                            Phone = "492567"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 9,
                            Name = "Adrian Ståhl",
                            Phone = "430709"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 12,
                            Name = "Åsa Fahlgren",
                            Phone = "273484"
                        },
                        new
                        {
                            Id = 5,
                            CityId = 3,
                            Name = "Adrian Fahlgren",
                            Phone = "520259"
                        },
                        new
                        {
                            Id = 6,
                            CityId = 4,
                            Name = "Yngve Dahl",
                            Phone = "691427"
                        },
                        new
                        {
                            Id = 7,
                            CityId = 1,
                            Name = "Osborn Ståhl",
                            Phone = "979565"
                        },
                        new
                        {
                            Id = 8,
                            CityId = 2,
                            Name = "Åsa Zackow",
                            Phone = "304225"
                        },
                        new
                        {
                            Id = 9,
                            CityId = 9,
                            Name = "Åsa Krall",
                            Phone = "368293"
                        },
                        new
                        {
                            Id = 10,
                            CityId = 10,
                            Name = "Kim Ålander",
                            Phone = "419846"
                        },
                        new
                        {
                            Id = 11,
                            CityId = 2,
                            Name = "Alva Dahl",
                            Phone = "912178"
                        },
                        new
                        {
                            Id = 12,
                            CityId = 5,
                            Name = "Lisbet Malmsten",
                            Phone = "264855"
                        },
                        new
                        {
                            Id = 13,
                            CityId = 5,
                            Name = "Olle Lindgren",
                            Phone = "793635"
                        },
                        new
                        {
                            Id = 14,
                            CityId = 12,
                            Name = "Lotta Malmsten",
                            Phone = "829277"
                        },
                        new
                        {
                            Id = 15,
                            CityId = 2,
                            Name = "Lotta Ålander",
                            Phone = "770813"
                        },
                        new
                        {
                            Id = 16,
                            CityId = 5,
                            Name = "Lotta Zackow",
                            Phone = "203738"
                        },
                        new
                        {
                            Id = 17,
                            CityId = 3,
                            Name = "Nisse Fahlgren",
                            Phone = "450215"
                        },
                        new
                        {
                            Id = 18,
                            CityId = 4,
                            Name = "Olle Dahl",
                            Phone = "961155"
                        },
                        new
                        {
                            Id = 19,
                            CityId = 5,
                            Name = "Mika Lindgren",
                            Phone = "903220"
                        },
                        new
                        {
                            Id = 20,
                            CityId = 9,
                            Name = "Mika Krall",
                            Phone = "199241"
                        },
                        new
                        {
                            Id = 21,
                            CityId = 11,
                            Name = "Lisbet Walker",
                            Phone = "613163"
                        },
                        new
                        {
                            Id = 22,
                            CityId = 6,
                            Name = "Dave Erixon",
                            Phone = "735203"
                        },
                        new
                        {
                            Id = 23,
                            CityId = 12,
                            Name = "Ilja Carlsson",
                            Phone = "510646"
                        },
                        new
                        {
                            Id = 24,
                            CityId = 10,
                            Name = "Kim Hjalmarsson",
                            Phone = "515553"
                        },
                        new
                        {
                            Id = 25,
                            CityId = 12,
                            Name = "Ulla Sventon",
                            Phone = "937750"
                        });
                });

            modelBuilder.Entity("LanguagePerson", b =>
                {
                    b.HasOne("MVC_8.Models.Home.Language", null)
                        .WithMany()
                        .HasForeignKey("LanguagesId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MVC_8.Models.Home.Person", null)
                        .WithMany()
                        .HasForeignKey("PeopleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("MVC_8.Models.Home.City", b =>
                {
                    b.HasOne("MVC_8.Models.Home.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("MVC_8.Models.Home.Person", b =>
                {
                    b.HasOne("MVC_8.Models.Home.City", "City")
                        .WithMany("People")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("MVC_8.Models.Home.City", b =>
                {
                    b.Navigation("People");
                });

            modelBuilder.Entity("MVC_8.Models.Home.Country", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}