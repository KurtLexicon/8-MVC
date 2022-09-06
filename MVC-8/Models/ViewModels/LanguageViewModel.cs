using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_8.Models.Home;
using System.ComponentModel.DataAnnotations;

namespace MVC_8.Models.ViewModels {
    public class LanguageViewModel : DetailsViewModel {

        // Properties (other than Id & Name)

        // Constructor
        public LanguageViewModel() : base(Const.Language) { }

        public LanguageViewModel(Language language) : base(Const.Language, language) { }

        // Override Methods

        public override Language GetItem(DataStore ds, bool getReferencedObjects = true) {
            return new() {
                Id = Id,
                Name = Name
            };
        }
    }
}
