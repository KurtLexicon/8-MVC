
namespace MVC_8.Models {
    public class LanguageViewModel : DetailsViewModel {

        // Properties (other than Id & Name)

        // Constructors

        public LanguageViewModel() : base(Const.Language) { }
        public LanguageViewModel(Language language) : base(Const.Language, language) { }

        // Override Methods

        public Language GetItem() {
            return new() {
                Id = Id,
                Name = Name
            };
        }
    }
}
