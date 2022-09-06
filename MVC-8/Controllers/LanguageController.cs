using Microsoft.AspNetCore.Mvc;
using MVC_8.Data;
using MVC_8.Models.Home;
using MVC_8.Models;
using MVC_8.Models.ViewModels;

namespace MVC_8.Controllers {
    public class LanguageController : ItemController<
            Language,
            LanguageListViewModel,
            LanguageViewModel,
            DataStoreLanguage> {

        public LanguageController(ApplicationDbContext dbContext)
            : base() {
            Ds = new DataStoreLanguage(dbContext, dbContext.Languages);
            Entity = Const.Language;
        }

        // === Prepare ViewModel

        override protected LanguageViewModel CreateViewModel(Language language) {
            return new LanguageViewModel(language);
        }

        override protected void AddViewData(LanguageViewModel model) {
            // Nothing to add
        }

        // === Create/Update Item from InputViewModel

        override public void UpdateItemFromInput(LanguageViewModel model, Language language) {
            language.Name = model.Name;
        }
    }
}
