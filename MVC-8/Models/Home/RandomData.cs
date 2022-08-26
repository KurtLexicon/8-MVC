namespace MVC_8.Models.Home {
    static public class RandomData {
        private static readonly Random rnd = new();

        static public List<Person> GetRandomPersons(int n) {
            return (new int[n]).Select(i => GetRandomPerson()).ToList();
        }

        static public Person GetRandomPerson() {
            string fName = FirstNames[rnd.Next(FirstNames.Count)];
            string lName = LastNames[rnd.Next(LastNames.Count)];
            string name = $"{fName} {lName}";
            string city = Cities[rnd.Next(Cities.Count)];
            string phone = $"{rnd.Next(100000, 999999)}";
            return new(name, city, phone);
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

        private static readonly List<string> Cities = new() {
            "Axevalla",
            "Floby",
            "Götene",
            "Hällekis",
            "Källby",
            "Lerdala",
            "New York",
            "New York",
            "New York",
            "Skulltorp",
            "Stenstorp",
            "Tibro",
            "Tidaholm",
            "Töreboda",
        };
    }
}
