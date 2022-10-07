//using Microsoft.AspNetCore.Mvc;
//using MVC_8.Data;
//using MVC_8.Models;
//using MVC_8.Models.Home;
//using MVC_8.Models.ViewModels;
//using System.Web.Http;
//using FromBodyAttribute = Microsoft.AspNetCore.Mvc.FromBodyAttribute;
//using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

//namespace MVC_8.Controllers {
//    abstract public class PersonAPIController : ApiController {

//        protected ApplicationDbContext DbContext { get; set; } = null!;
//        protected DataStoreItem<Person> Ds { get; set; } = null!;
//        protected EntityConst Entity { get; set; } = null!;

//        protected PersonAPIController() : base() { }

//        // =======================================
//        // Get Items
//        // =======================================

//        [HttpPost]
//        public ActionResult GetItems([FromBody] string filter) {
//            try {
//                int nTotal = Ds.GetNumberOfItems();
//                List<EntityItem> items = Ds.GetItemsFiltered(filter);
//                PersonListViewModel model = new();
//                model.AddData(items, nTotal, filter);
//                return View("PartialViewList", model);
//            }
//            catch (Exception e) {
//                return HandleError(e);
//            }
//        }

//        // =======================================
//        // Get Item
//        // =======================================

//        [HttpPost]
//        public IActionResult GetItem([FromBody] int id) {
//            try {
//                ResponseData responseData = new();

//                Person item;
//                if (id == 0) {
//                    item = new();
//                } else {
//                    try {
//                        item = Ds.GetItemById(id);
//                    }
//                    catch (DataStore.ItemNotFoundException) {
//                        item = new();
//                        responseData.SetFail($"{Entity.Name} {id} not found");
//                    }
//                }

//                PersonViewModel model = CreateViewModel(item);
//                model.AddResponseData(responseData);
//                return View("PvDetail", model);
//            }
//            catch (Exception e) {
//                return HandleError(e);
//            }
//        }

//        // =======================================
//        // === Add or Update Item
//        // =======================================

//        [HttpPost]
//        public IActionResult AddOrUpdateItem([FromBody] PersonViewModel input) {
//            PersonViewModel model;
//            try {
//                if (!ModelState.IsValid) throw new DataStore.InfoException("Please enter valid data");

//                if (input.Id == 0) {

//                    // Add new item from valid input

//                    EntityItem entityItem = input.GetItem(Ds);
//                    if (entityItem is not Person) throw new Exception("Program error: PersonViewModel.GetItem did not return Person");
//                    Person item = Ds.AddItem((Person)entityItem);
//                    model = CreateViewModel(item);
//                    model.AddSuccess($"{Entity.Name} {item.Id} added");

//                } else {

//                    // Update existing item from valid input

//                    try {
//                        Person item = Ds.GetItemById(input.Id);
//                        UpdateItemFromInput(input, item);
//                        Ds.SaveChanges();
//                        model = CreateViewModel(item);
//                        model.AddSuccess($"{Entity.Name} {item.Id} updated");
//                    }
//                    catch (DataStore.ItemNotFoundException) {
//                        Person item = new();
//                        throw new DataStore.InfoException($"{Entity.Name} {input.Id} not found");
//                    }
//                }
//            }

//            catch (DataStore.InfoException ex) {
//                model = input;
//                AddViewData(model);
//                model.AddFail(ex.Message);
//            }

//            return View("PvDetail", model);
//        }

//        // =======================================
//        // === Delete Item 
//        // =======================================

//        public class ReqBodyDelete {
//            public ReqBodyDelete() {
//                Id = 0;
//                Filter = string.Empty;
//            }
//            public int Id { get; set; }
//            public string Filter { get; set; }
//        }

//        [HttpPost]
//        public IActionResult DeleteItem([FromBody] ReqBodyDelete req) {
//            int id = req.Id;
//            string filter = req.Filter;
//            string errorMessage = "";

//            try {
//                Ds.DeleteItem(id);
//            }
//            catch (DataStore.ItemNotFoundException) {
//                // Item to delete not found, maybe deleted already, just let it pass
//            }
//            catch (DataStore.InfoException ex) {
//                errorMessage = ex.Message;
//            }

//            int nTotal = Ds.GetNumberOfItems();
//            List<EntityItem> items = Ds.GetItemsFiltered(filter);
//            PersonListViewModel model = new();
//            model.AddData(items, nTotal, filter);
//            model.ErrorMessage = errorMessage;
//            return View("PartialViewList", model);
//        }

//        // =======================================
//        // === Handle Errors
//        // =======================================

//        private ViewResult HandleError(Exception e) {
//            ResponseData responseData = new();
//            string text;
//            if (e != null && !string.IsNullOrWhiteSpace(e.Message)) {
//                text = e.Message;
//            } else if (e != null) {
//                text = e.ToString();
//            } else {
//                text = "Unknown error";
//            }
//            responseData.SetFail(text);
//            return View("PartialViewErrorMessage", responseData);
//        }

//        // ======================================================
//        // Even if most things are identical in the controlling
//        // of different entities, some things differ, these are 
//        // handled by each entity controllers itself, but need
//        // be declared here as abstract classes, if are used
//        // from this class
//        // ======================================================

//        abstract protected PersonViewModel CreateViewModel(Person item);
//        abstract protected void AddViewData(PersonViewModel model);
//        abstract public void UpdateItemFromInput(PersonViewModel model, Person item);
//    }
//}
