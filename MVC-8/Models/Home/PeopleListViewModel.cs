namespace MVC_8.Models.Home {
    public class PeopleListViewModel {
        public List<Person> People { get; set; }
        public int NAllPeople { get; set; }
        public string Filter { get; set; }

        public PeopleListViewModel(PeopleData peopleData, string filter) {
            NAllPeople = peopleData.People.Count;
            Filter = filter;
            People = peopleData.FilteredPeople(filter);
        }
    }
}
