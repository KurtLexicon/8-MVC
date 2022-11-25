using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_8.Data;
using MVC_8.Models;


namespace MVC_8.Controllers {
    public class PeopleController : Controller {

        private ApplicationDbContext DbContext { get; set; }
        private DataStorePeople Ds { get; set; }
        private EntityConst Entity { get; set; } = Const.Person;
        private PersonWorker Worker { get; set; }

        public PeopleController(ApplicationDbContext dbContext) : base() {
            DbContext = dbContext;
            Ds = new DataStorePeople(dbContext, dbContext.People);
            Worker = new PersonWorker(dbContext);
        }

        // ===================================
        // Index
        // ===================================

        [Authorize(Roles = "Admin,User")]
        public ViewResult Index() {
            return View(new PageViewModel(Entity));
        }

        // =======================================
        // Get List
        // =======================================


        [HttpGet]
        [Authorize(Roles = "Admin, User")]
        public PartialViewResult GetList(string filterText) {
            PersonListViewModel model = Worker.GetList(filterText);
            return PartialView(model);
        }

        // =======================================
        // Get Item
        // =======================================

        [HttpPost]
        [Authorize(Roles = "Admin, User")]
        public PartialViewResult GetItem([FromBody] int id) {
            PersonViewModel model = Worker.GetItemModel(id);
            return PartialView(model);
        }

        // =======================================
        // === Add Random Item
        // =======================================

        [Authorize(Roles = "Admin, User")]
        [HttpPost]
        public PartialViewResult AddRandomItem() {
            PersonViewModel model = Worker.AddRandomItem();
            return PartialView(model);
        }

        // =======================================
        // === Add Item
        // =======================================

        [Authorize(Roles = "Admin, User")]
        [HttpPost]
        public PartialViewResult AddItem([FromBody] PersonViewModel input) {
            PersonViewModel model;
            try {
                if (!ModelState.IsValid) throw new InfoException("Please enter valid data");
                model = Worker.AddItem(input);
            }

            catch (InfoException ex) {
                model = input;
                model.AddViewData(Ds.Cities, Ds.Languages);
                model.AddFail(ex.Message);
            }

            return PartialView(model);
        }

        // =======================================
        // === Update Item
        // =======================================

        [Authorize(Roles = "Admin, User")]
        [HttpPost]
        public PartialViewResult UpdateItem([FromBody] PersonViewModel input) {
            PersonViewModel model;
            try {
                if (!ModelState.IsValid) throw new InfoException("Please enter valid data");
                model = Worker.UpdateItem(input);
            }
            catch (InfoException ex) {
                model = input;
                model.AddViewData(Ds.Cities, Ds.Languages);
                model.AddFail(ex.Message);
            }

            return PartialView(model);
        }

        // =======================================
        // === Delete Item
        // =======================================

        [Authorize(Roles = "Admin, User")]
        [HttpDelete]
        public PartialViewResult DeleteItem(int id) {
            SharedViewModel model = Worker.DeleteItem(id);
            return PartialView(model);
        }
    }
}
