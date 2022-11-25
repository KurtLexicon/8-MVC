using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVC_8.Data;
using MVC_8.Models;

namespace MVC_8.Controllers
{
    public class CitiesAPIController : Controller
    {
        private ApplicationDbContext DbContext { get; set; } = null!;
        private DataStoreCity Ds { get; set; } = null!;
        private EntityConst Entity { get; set; } = Const.City;
        private CityWorker Worker { get; set; }

        public CitiesAPIController(ApplicationDbContext dbContext) : base()
        {
            DbContext = dbContext;
            Ds = new DataStoreCity(dbContext, dbContext.Cities);
            Worker = new CityWorker(dbContext);
        }

        // =======================================
        // Get List
        // =======================================

        [HttpGet]
        public JsonResult GetList(string filterText)
        {
            try
            {
                List<City> items = Worker.GetItemsList(filterText);
                return Json(items);
            }
            catch (Exception e)
            {
                return Json(new ErrorResponse(e));
            }
        }

        // =======================================
        // Get Item
        // =======================================

        [HttpGet]
        public JsonResult GetItem(int id)
        {
            try
            {
                CityViewModel model = Worker.GetItem(id);
                return Json(model);
            }
            catch (Exception e)
            {
                return Json(new ErrorResponse(e));
            }
        }

        // =======================================
        // Get Select Lists
        // =======================================

        [HttpGet]
        public JsonResult GetSelectLists(int id)
        {
            try
            {
                var model = new {
                    SelectListCountries = Ds.Countries.Select(x => new { Text = x.Id.ToString(), Value = x.Name }).ToList(),
                };
                return Json(model);
            }
            catch (Exception e)
            {
                return Json(new ErrorResponse(e));
            }
        }

        // =======================================
        // === Add or Update Item
        // =======================================

        [HttpPost]
        public JsonResult AddOrUpdateItem([FromBody] CityViewModel input)
        {
            try
            {
                if (!ModelState.IsValid || input == null)
                    throw new InfoException("Please enter valid data");

                CityViewModel model = input.Id == 0
                    ? Worker.AddItem(input)
                    : Worker.UpdateItem(input);
                return Json(model);
            }
            catch (Exception e)
            {
                return Json(new ErrorResponse(e));
            }

        }

        // =======================================
        // Add Item
        // =======================================


        [HttpPost]
        public JsonResult AddItem([FromBody] CityViewModel input)
        {
            try
            {
                if (!ModelState.IsValid || input == null)
                    throw new InfoException("Please enter valid data");
                CityViewModel model = Worker.AddItem(input);
                return Json(model);
            }
            catch (Exception e)
            {
                return Json(new ErrorResponse(e));
            }
        }

        // =======================================
        // Update Item
        // =======================================

        [HttpPost]
        public JsonResult UpdateItem([FromBody] CityViewModel input)
        {
            try
            {
                if (!ModelState.IsValid || input == null)
                    throw new InfoException("Please enter valid data");
                CityViewModel model = Worker.UpdateItem(input);
                return Json(model);
            }
            catch (Exception e)
            {
                return Json(new ErrorResponse(e));
            }
        }

        // =======================================
        // Delete Item
        // =======================================

        [HttpDelete]
        public JsonResult DeleteItem(int id)
        {
            try
            {
                throw new InfoException("Not Implemented");
                Worker.DeleteItem(id);
                SharedViewModel model = new();
                return Json(model);
            }
            catch (Exception e)
            {
                return Json(new ErrorResponse(e));
            }
        }
    }
}
