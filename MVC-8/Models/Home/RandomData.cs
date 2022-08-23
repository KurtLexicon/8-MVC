namespace MVC_8.Models.Home {
    static public class RandomData {
        private static readonly Random rnd = new ();

        static public List<Person> GetPersons (int n) {
            return (new int[n]).Select(i => GetPerson()).ToList();
        }

        static public Person GetPerson() { 
            string fName = FirstNames[rnd.Next(FirstNames.Count)];
            string lName = LastNames[rnd.Next(LastNames.Count)];
            string name = $"{fName} {lName}";
            string city = Cities[rnd.Next(Cities.Count)];
            string phone = $"{rnd.Next(100000, 999999)}";
            return new() {
                Name = name,
                City = city,
                Phone = phone
            };
        }

        private static readonly List<string> LastNames = new() {
            "Andersson",
            "Bengtsson",
            "Carlsson",
            "Bildt",
            "Lindgren",
            "Krall",
        };
        private static readonly List<string> FirstNames = new() {
            "Lisbet",
            "Olle",
            "Kalle",
            "Ulla",
            "Nisse",
            "Lotta",
        };
        private static readonly List<string> Cities = new() {
            "Töreboda",
            "New York",
            "Stenstorp",
            "Tibro",
            "Götene",
            "Axevalla",
        };
    }

}
