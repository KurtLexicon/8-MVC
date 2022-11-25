using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVC_8.Data;
using MVC_8.Models;
using MVC_8.Models;

namespace MVC_8.Controllers
{
    public class CountriesAPIController : Controller
    {
        private ApplicationDbContext DbContext { get; set; } = null!;
        private DataStoreCountry Ds { get; set; } = null!;
        private EntityConst Entity { get; set; } = Const.Country;
        private CountryWorker Worker { get; set; }

        public CountriesAPIController(ApplicationDbContext dbContext) : base()
        {
            DbContext = dbContext;
            Ds = new DataStoreCountry(dbContext, dbContext.Countries);
            Worker = new CountryWorker(dbContext);
        }

        // =======================================
        // Get List
        // =======================================

        [HttpGet]
        public JsonResult GetList(string filterText)
        {
            try
            {
                List<Country> items = Worker.GetItemsList(filterText);
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
                CountryViewModel model = Worker.GetItem(id);
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
                var model = new { };
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
        public JsonResult AddOrUpdateItem([FromBody] CountryViewModel input)
        {
            try
            {
                if (!ModelState.IsValid || input == null)
                    throw new InfoException("Please enter valid data");

                CountryViewModel model = input.Id == 0
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
        public JsonResult AddItem([FromBody] CountryViewModel input)
        {
            try
            {
                if (!ModelState.IsValid || input == null)
                    throw new InfoException("Please enter valid data");
                CountryViewModel model = Worker.AddItem(input);
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
        public JsonResult UpdateItem([FromBody] CountryViewModel input)
        {
            try
            {
                if (!ModelState.IsValid || input == null)
                    throw new InfoException("Please enter valid data");
                CountryViewModel model = Worker.UpdateItem(input);
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
