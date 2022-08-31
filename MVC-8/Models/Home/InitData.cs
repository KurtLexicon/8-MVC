namespace MVC_8.Models.Home {
    static public class InitData {
        private static readonly Random rnd = new();


        static public List<Country> SeedCountries() {
            int nextId = 1;
            return dicCountries
                .Keys
                .Select(countryName => new Country(nextId++, countryName))
                .ToList();
        }

        static public List<City> SeedCities(List<Country> countries) {
            int nextId = 1;
            return countries.SelectMany(
                country => dicCountries[country.Name].Select(
                    strCity=> new City(nextId++, strCity, country)
                )
            ).ToList(); ;
        }

        static public List<Person> SeedPersons(List<City> cities, int n) {
            return Enumerable
                .Range(1, n)
                .Select(id => GetRandomPerson(cities, id))
                .ToList();
        }

        static public Person GetRandomPerson(List<City> cities, int id = 0) {
            Person p = new() {
                Id = id,
                City = GetRandomCity(cities),
                Name = GetRandomName(),
                Phone = GetRandomPhone()
            };
            p.CityId = p.City.Id;
            return p;
        }

        static private string GetRandomName() {
            string fName = FirstNames[rnd.Next(FirstNames.Count)];
            string lName = LastNames[rnd.Next(LastNames.Count)];
            return $"{fName} {lName}";
        }

        static private string GetRandomPhone() {
            return $"{rnd.Next(100000, 999999)}";
        }

        static private City GetRandomCity(List<City> cities) {
            return cities[rnd.Next(cities.Count)];
        }


        private static readonly List<string> LastNames = new() {
            "Bildt",
            "Carlsson",
            "Dahl",
            "Erixon",
            "Fahlgren",
            "Hjalmarsson",
            "Ivarsson",
            "Jonsson",
            "Lindgren",
            "Krall",
            "Malmsten",
            "Ståhl",
            "Sventon",
            "Vretman",
            "Walker",
            "Zackow",
            "Ålander",
        };

        private static readonly List<string> FirstNames = new() {
            "Adrian",
            "Beda",
            "Dave",
            "Kalle",
            "Kim",
            "Klas",
            "Lisbet",
            "Lotta",
            "Mika",
            "Nisse",
            "Olle",
            "Osborn",
            "Ture",
            "Ulla",
            "Yngve",
            "Åsa",
        };

        private static readonly Dictionary<string, List<string>> dicCountries = new() {
            {"Skaraborg", new List<string>() {
                "Axevalla",
                "Floby",
                "Götene",
                "Hällekis",
                "Källby",
                "Lerdala",
                "Skulltorp",
                "Stenstorp",
                "Tibro",
                "Tidaholm",
                "Töreboda"
            }},
            {"USA", new List<string>() {
                "New York"
            }}
        };
    }
}
