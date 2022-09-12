using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVC_8.Data;
using MVC_8.Models;
using MVC_8.Models.Home;
using MVC_8.Models.Shared;
using MVC_8.Models.ViewModels;

namespace MVC_8.Controllers {
    public class CitiesController : Controller {

        private ApplicationDbContext DbContext { get; set; } = null!;
        private DataStoreCity Ds { get; set; } = null!;
        private EntityConst Entity { get; set; } = Const.City;

        public CitiesController(ApplicationDbContext dbContext) : base() {
            DbContext = dbContext;
            Ds = new DataStoreCity(dbContext, dbContext.Cities);
        }

        // =======================================
        // Actions
        // =======================================

        [Authorize(Roles = "Admin")]
        public ViewResult Index() {
            return View(new PageViewModel(Entity));
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public PartialViewResult GetList(string filterText) {
            int nTotal = Ds.GetNumberOfItems();
            List<EntityItem> items = Ds.GetItemsFiltered(filterText);
            CityListViewModel model = new();
            model.AddData(items, nTotal, filterText);
            return PartialView(model);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public PartialViewResult GetItem([FromBody] int id) {
            string errorMessage = "";
            City item;
            try {
                item = id != 0 ? Ds.GetItemById(id) : new();
            }
            catch (DataStore.ItemNotFoundException) {
                item = new();
                errorMessage = $"{Entity.Name} {id} not found";
            }

            CityViewModel model = new(item, Ds.Countries.ToList());
            model.AddFail(errorMessage);
            return PartialView(model);
        }


        [Authorize(Roles = "Admin")]
        [HttpPost]
        public PartialViewResult AddItem([FromBody] CityViewModel input) {
            CityViewModel model;
            try {
                if (!ModelState.IsValid) throw new InfoException("Please enter valid data");
                City item = input.GetItem();
                Ds.AddItem(item);
                model = new(item, Ds.Countries.ToList());
                model.AddSuccess($"{Entity.Name} {item.Id} added");

            }

            catch (InfoException ex) {
                model = input;
                model.AddViewData(Ds.Countries.ToList());
                model.AddFail(ex.Message);
            }

            return PartialView(model);
        }


        [Authorize(Roles = "Admin")]
        [HttpPost]
        public PartialViewResult UpdateItem([FromBody] CityViewModel input) {
            CityViewModel model;
            try {
                if (!ModelState.IsValid) throw new InfoException("Please enter valid data");

                City item = Ds.GetItemById(input.Id);
                item.Name = input.Name;
                item.Country = Ds.GetItemById(Ds.Countries, input.CountryId);
                item.CountryId = input.CountryId;
                Ds.SaveChanges();

                model = new(item, Ds.Countries.ToList());
                model.AddSuccess($"{Entity.Name} {item.Id} updated");
            }
            catch (DataStore.ItemNotFoundException) {
                model = input;
                model.AddViewData(Ds.Countries.ToList());
                model.AddFail($"{Entity.Name} {input.Id} not found");
            }
            catch (InfoException ex) {
                model = input;
                model.AddViewData(Ds.Countries.ToList());
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
