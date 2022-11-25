using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVC_8.Data;
using MVC_8.Models;



namespace MVC_8.Controllers {
    public class LanguagesAPIController : Controller {
        private ApplicationDbContext DbContext { get; set; }
        private DataStoreLanguage Ds { get; set; }
        private EntityConst Entity { get; set; } = Const.Language;
        private LanguageWorker Worker { get; set; }

        public LanguagesAPIController(ApplicationDbContext dbContext)
            : base() {
            DbContext = dbContext;
            Ds = new DataStoreLanguage(dbContext, dbContext.Languages);
            Worker = new LanguageWorker(dbContext);

        }

        // ===================================
        // Get List
        // ===================================

        [HttpGet]
        public JsonResult GetList(string filterText) {
            try
            {
                List<Language> items = Worker.GetItemsList(filterText);
                return Json(items);
            }
            catch (Exception e)
            {
                return Json(new ErrorResponse(e));
            }
        }

        // ===================================
        // Get Item
        // ===================================

        [HttpGet]
        public JsonResult GetItem(int id) {
            try
            {
                LanguageViewModel model = Worker.GetItem(id);
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
        public JsonResult AddOrUpdateItem([FromBody] LanguageViewModel input)
        {
            try
            {
                if (!ModelState.IsValid || input == null)
                    throw new InfoException("Please enter valid data");

                LanguageViewModel model = input.Id == 0
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
