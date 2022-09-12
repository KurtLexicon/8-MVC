using MVC_8.Models.Home;

namespace MVC_8.Models.ViewModels {
    public class CountryViewModel : DetailsViewModel {

        // Properties (other than Id & Name)

        // Constructor

        public CountryViewModel() : base(Const.Country) { }
        public CountryViewModel(Country country) : base(Const.Country, country) { }

        // Get Item

        public Country GetItem() {
            return new() {
                Id = Id,
                Name = Name
            };
        }

    }
}
