
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_8.Data;
using MVC_8.Models;


namespace MVC_8.Controllers
{
    public class PeopleAPIController : Controller
    {

        private ApplicationDbContext Db { get; set; }
        private DbSet<Person> DbSet { get; set; }
        private DataStoreItem<Person> Ds { get; set; }
        private EntityConst Entity { get; set; } = Const.Person;
        private PersonWorker Worker { get; set; }

        public PeopleAPIController(ApplicationDbContext dbContext) : base()
        {
            Db = dbContext;
            DbSet = dbContext.People;
            Ds = new DataStorePeople(dbContext, dbContext.People);
            Worker = new PersonWorker(dbContext);
        }

        // =======================================
        // Get List
        // =======================================

        [HttpGet]
        public JsonResult GetList(string filter)
        {
            try
            {
                List<Person> items = Worker.GetItemsList(filter);
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
                Person item = Worker.GetItem(id);
                PersonApiModel model = new(item);
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
        public JsonResult GetSelectLists()
        {
            try
            {
                var model = new {
                    SelectListCities = Ds.Cities.Select(x => new { Text = x.Id.ToString(), Value = x.Name }).ToList(),
                    SelectListLanguages = Ds.Languages.Select(x => new { Text = x.Id.ToString(), Value = x.Name }).ToList(),
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
        public JsonResult AddOrUpdateItem([FromBody] PersonViewModel input)
        {
            PersonViewModel model;
            try
            {
                if (!ModelState.IsValid)
                    throw new InfoException("Please enter valid data");

                model = input.Id == 0
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
        // === Delete Item 
        // =======================================

        [HttpDelete]
        public JsonResult DeleteItem(int id)
        {
            try
            {
                SharedViewModel model = Worker.DeleteItem(id);
                return Json(model);
            }
            catch (Exception e)
            {
                return Json(new ErrorResponse(e));
            }
        }
    }
}
