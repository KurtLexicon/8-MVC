
namespace MVC_8.Models.Home {
    public class PeoplePage {
        public PeopleViewModel PeopleViewModel { get; set; }
        public CreatePersonViewModel CreatePersonViewModel { get; set; }

        public PeoplePage(PeopleViewModel peopleViewModel) {
            PeopleViewModel = peopleViewModel;
            CreatePersonViewModel = new CreatePersonViewModel();
        }
    }
}
