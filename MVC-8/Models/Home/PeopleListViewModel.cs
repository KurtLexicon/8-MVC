namespace MVC_8.Models.Home {
    public class PeopleListViewModel {
        public List<Person> People { get; set; }
        public int NAllPeople { get; set; }
        public string Filter { get; set; }

        public PeopleListViewModel(List<Person> people, int nPeople, string filter) {
            NAllPeople = nPeople;
            Filter = filter;
            People = people;
        }
    }
}
