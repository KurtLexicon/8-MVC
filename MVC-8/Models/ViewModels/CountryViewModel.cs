using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_8.Models.Home;
using System.ComponentModel.DataAnnotations;

namespace MVC_8.Models.ViewModels {
    public class CountryViewModel : DetailsViewModel {

        // Properties (other than Id & Name)

        // Constructor
        public CountryViewModel() : base(Const.Country) { }

        public CountryViewModel(Country country) : base(Const.Country, country) { }

        // Override Methods

        public override Country GetItem(DataStore ds, bool getReferencedObjects = true) {
            return new() {
                Id = Id,
                Name = Name
            };
        }

    }
}
