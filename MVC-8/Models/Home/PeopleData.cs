namespace MVC_8.Models.Home {
    public class PeopleData {
        public class PersonIdNotFoundException : Exception { };

        static int _lastId = 100;
        static public int GetNextId() {
            return Interlocked.Increment(ref _lastId);
        }

        public List<Person> People { get; set; } = new List<Person>();

        public PeopleData() {
            People = RandomData.GetRandomPersons(5);
        }

        public PeopleData(int nRandomPeople) {
            People = RandomData.GetRandomPersons(nRandomPeople);
        }

        public Person GetPersonById(int id) {
            Person? person = People.Find(p => p.Id == id);
            if (person == null) throw new PersonIdNotFoundException();
            return person;
        }

        public Person AddPerson(Person person) {
            person.SetId();
            People.Add(person);
            return person;
        }

        public Person UpdatePerson(CreatePersonViewModel input) {
            Person person = GetPersonById(input.Id);
            person.Name = input.Name;
            person.City = input.City;
            person.Phone = input.Phone;
            return person;
        }

        public void DeletePerson(int id) {
            Person person = GetPersonById(id);
            People.Remove(person);
        }

        public List<Person> FilteredPeople(string filter) {
            return string.IsNullOrWhiteSpace(filter)
                ? People
                : People.Where(person => FilteredPerson(person, filter)).ToList();
        }

        static private bool FilteredPerson(Person person, string filter) {
            Boolean ret = string.IsNullOrWhiteSpace(filter);
            ret = ret || person.Name.Contains(filter, StringComparison.CurrentCultureIgnoreCase);
            ret = ret || person.City.Contains(filter, StringComparison.CurrentCultureIgnoreCase);
            return ret;
        }
    }
}
