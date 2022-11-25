namespace MVC_8.Models {
    static public class InitData {
        private static readonly Random rnd = new();

        static public List<Language> SeedLanguages() {
            int nextId = 1;
            return Languages
                .Select(name => new Language() { Id = nextId++, Name = name })
                .ToList();
        }

        static public List<Country> SeedCountries() {
            int nextId = 1;
            return dicCountries
                .Keys
                .Select(name => new Country() { Id = nextId++, Name = name })
                .ToList();
        }

        static public List<City> SeedCities(List<Country> countries) {
            int nextId = 1;
            return countries.SelectMany(
                country => dicCountries[country.Name].Select(
                    strCity => new City() { Id = nextId++, Name = strCity, CountryId = country.Id }
                )
            ).ToList(); ;
        }

        static public List<Person> SeedPersons(List<City> cities, int n) {
            List<Language> emptyLanguageList = new();
            return Enumerable
                .Range(1, n)
                .Select(id => GetRandomPerson(cities, emptyLanguageList, id))
                .Select(p => RemoveCityReference(p))
                .ToList();
        }

        static private Person RemoveCityReference(Person person) {
            person.City = null!;
            return person;
        }

        static public Person GetRandomPerson(List<City> cities, List<Language> languages, int id = 0) {
            City city = GetRandomCity(cities);
            Person p = new() {
                Id = id,
                City = city,
                CityId = city.Id,
                Name = GetRandomName(),
                Phone = GetRandomPhone(),
                Languages = GetRandomLanguages(languages)
            };
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

        public struct PersonLanguage {
            public int PeopleId;
            public int LanguagesId;
        }

        static public PersonLanguage[] SeedPersonLanguages(List<Person> persons, List<Language> languages) {
            return persons
                .SelectMany(
                    p => GetRandomLanguages(languages)
                        .Select(l => new PersonLanguage() { PeopleId = p.Id, LanguagesId = l.Id })
                )
                .ToArray();
        }

        static private List<Language> GetRandomLanguages(List<Language> languages) {
            if (languages.Count == 0) return languages;

            int n = rnd.Next(Math.Min(languages.Count, 5));
            return RandomValuesFromList(languages, n);
        }

        static List<T> RandomValuesFromList<T>(List<T> lst, int n) {
            return lst
                .Select(x => new { Item = x, Random = rnd.Next() })
                .OrderBy(x => x.Random)
                .Take(n)
                .Select(x => x.Item)
                .ToList();
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
            "Alva",
            "Ylva",
            "Ilja",
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

        private static readonly List<string> Languages = new() {
            "Klingon",
            "Meänkieli",
            "Mixtec",
            "Papiamento",
            "Swahili",
            "Volapük",
            "Väschözzga",
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
