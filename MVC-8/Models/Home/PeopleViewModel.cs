namespace MVC_8.Models.Home {
    public class PeopleViewModel {
        public string Filter { get; set; } = "";
        public List<Person> People { get; set; } = new List<Person>();

        // Show/Hide Sections
        public bool ShowAddPerson { get; set; } = false;
        public bool ShowFilter { get; set; } = false;

        // Input fields
        public string Name { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

        public PeopleViewModel(int nRandomPeople) {
            People = RandomData.GetPersons(nRandomPeople);
        }

        public List<Person> FilteredPeople() {
            return string.IsNullOrWhiteSpace(Filter) 
                ? People
                : People.Where(person => FilteredPerson(person)).ToList();
        }

        private bool FilteredPerson(Person person) {
            Boolean ret = string.IsNullOrWhiteSpace(Filter);
            ret = ret || person.Name.Contains(Filter, StringComparison.CurrentCultureIgnoreCase);
            ret = ret || person.City.Contains(Filter, StringComparison.CurrentCultureIgnoreCase);
            return ret;
        }
    }
}
