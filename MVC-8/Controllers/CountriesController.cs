using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVC_8.Data;
using MVC_8.Models;


namespace MVC_8.Controllers {
    public class CountriesController : Controller {
        private ApplicationDbContext DbContext { get; set; } = null!;
        private DataStoreCountry Ds { get; set; } = null!;
        private EntityConst Entity { get; set; } = Const.Country;

        public CountriesController(ApplicationDbContext dbContext)
            : base() {
            DbContext = dbContext;
            Ds = new DataStoreCountry(dbContext, dbContext.Countries);
        }

        // ===================================
        // Actions
        // ===================================

        [Authorize(Roles = "Admin")]
        public ViewResult Index() {
            return View(new PageViewModel(Entity));
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public PartialViewResult GetList(string filterText) {
            int nTotal = Ds.GetNumberOfItems();
            List<EntityItem> items = Ds.GetItemsFiltered(filterText);
            CountryListViewModel model = new();
            model.AddData(items, nTotal, filterText);
            return PartialView(model);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public PartialViewResult GetItem([FromBody] int id) {
            string errorMessage = "";
            Country item;
            try {
                item = id != 0 ? Ds.GetItemById(id) : new();
            }
            catch (DataStore.ItemNotFoundException) {
                item = new();
                errorMessage = $"{Entity.Name} {id} not found";
            }
            CountryViewModel model = new(item);
            model.AddFail(errorMessage);
            return PartialView(model);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public PartialViewResult AddItem([FromBody] CountryViewModel input) {
            CountryViewModel model;
            try {
                if (!ModelState.IsValid) throw new InfoException("Please enter valid data");
                Country item = input.GetItem();
                Ds.AddItem(item);
                model = new(item);
                model.AddSuccess($"{Entity.Name} {item.Id} added");
            }
            catch (InfoException ex) {
                model = input;
                model.AddFail(ex.Message);
            }
            return PartialView(model);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public PartialViewResult UpdateItem([FromBody] CountryViewModel input) {
            CountryViewModel model;
            try {
                if (!ModelState.IsValid) throw new InfoException("Please enter valid data");
                try {
                    Country item = Ds.GetItemById(input.Id);
                    item.Name = input.Name;
                    Ds.SaveChanges();

                    model = new(item);
                    model.AddSuccess($"{Entity.Name} {item.Id} updated");
                }
                catch (DataStore.ItemNotFoundException) {
                    throw new InfoException($"{Entity.Name} {input.Id} not found");
                }
            }
            catch (InfoException ex) {
                model = input;
                model.AddFail(ex.Message);
            }
            return PartialView(model);
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete]
        public PartialViewResult DeleteItem(int id) {
            string errorMessage = "";

            try {
                Ds.DeleteItem(id);
            }
            catch (InfoException ex) {
                errorMessage = ex.Message;
            }

            SharedViewModel model = new(errorMessage);
            return PartialView(model);
        }
    }
}
