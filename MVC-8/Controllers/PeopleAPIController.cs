using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using MVC_8.Data;
using MVC_8.Models;
using MVC_8.Models.Home;
using MVC_8.Models.Shared;
using MVC_8.Models.ViewModels;
using Newtonsoft.Json;

namespace MVC_8.Controllers {
    abstract public class ItemController<
            Person,
            TListViewModel,
            TInputViewModel,
            TDataStore> : Controller
        where Person : EntityItem, new()
        where TListViewModel : ListViewModel, new()
        where TInputViewModel : DetailsViewModel
        where TDataStore : DataStoreItem<Person> {

        protected ApplicationDbContext DbContext { get; set; } = null!;
        protected DataStoreItem<Person> Ds { get; set; } = null!;
        protected EntityConst Entity { get; set; } = null!;

        protected ItemController() : base() { }

        // =======================================
        // Get Items
        // =======================================
 
        public class FilterType
        {
            public string filter { get; set; } = "";
        }
        //        public IActionResult GetItems([FromBody] FilterType filterType)

        [HttpGet]
        public IActionResult GetItems(string value)
        {
            try
            {
                string filter = value;
                int nTotal = Ds.GetNumberOfItems();
                List<EntityItem> items = Ds.GetItemsFiltered(filter);
                TListViewModel model = new();
                model.AddData(items, nTotal, filter);
                return Json(model, null);
                // return View("PartialViewList", model);
            }
            catch (Exception e) {
                return HandleError(e);
            }
        }

        // =======================================
        // Get Item
        // =======================================

        [HttpGet,HttpPost]
        public IActionResult GetItem(int value) {
            try {
                int id = value;
                ResponseData responseData = new();

                Person item;
                if (id == 0) {
                    item = new();
                } else {
                    try {
                        item = Ds.GetItemById(id);
                    }
                    catch (DataStore.ItemNotFoundException) {
                        item = new();
                        responseData.SetFail($"{Entity.Name} {id} not found");
                    }
                }

                TInputViewModel model = CreateViewModel(item);
                model.AddResponseData(responseData);
                return Json(model, null);
                // View("PvDetail", model);
            }
            catch (Exception e) {
                return HandleError(e);
            }
        }

        // =======================================
        // === Add or Update Item
        // =======================================

        [HttpPost]
        public IActionResult AddOrUpdateItem([FromBody] PersonViewModel input) {
            PersonViewModel model;
            try {
                if (!ModelState.IsValid) throw new InfoException("Please enter valid data");

                if (input.Id == 0) {

                    // Add new item from valid input

                    List<Language> languages = Ds.GetItemsByIds(Ds.Languages, input.LanguageIds);
                    EntityItem entityItem = input.GetItem(languages);
                    if (entityItem is not Person) throw new Exception("Program error: TInputViewModel.GetItem did not return Person");
                    Person item = Ds.AddItem((Person)entityItem);
                    model = new(item, Ds.Cities.ToList(), Ds.Languages.ToList());
                    model.AddSuccess($"{Entity.Name} {item.Id} added");

                } else {

                    // Update existing item from valid input

                    try {
                        Person item = Ds.GetItemById(input.Id);
                        UpdateItemFromInput(input, item);
                        Ds.SaveChanges();
                        model = CreateViewModel(item);
                        model.AddSuccess($"{Entity.Name} {item.Id} updated");
                    }
                    catch (DataStore.ItemNotFoundException) {
                        Person item = new();
                        throw new InfoException($"{Entity.Name} {input.Id} not found");
                    }
                }
            }

            catch (InfoException ex) {
                model = input;
                AddViewData(model);
                model.AddFail(ex.Message);
            }

            return Json(model, null);
            // return View("PvDetail", model);
        }

        // =======================================
        // === Delete Item 
        // =======================================

        public class ReqBodyDelete {
            public ReqBodyDelete() {
                Id = 0;
                Filter = string.Empty;
            }
            public int Id { get; set; }
            public string Filter { get; set; }
        }

        [HttpPost]
        public IActionResult DeleteItem([FromBody] ReqBodyDelete req) {
            int id = req.Id;
            string filter = req.Filter;
            string errorMessage = "";

            try {
                Ds.DeleteItem(id);
            }
            catch (DataStore.ItemNotFoundException) {
                // Item to delete not found, maybe deleted already, just let it pass
            }
            catch (InfoException ex) {
                errorMessage = ex.Message;
            }

            int nTotal = Ds.GetNumberOfItems();
            List<EntityItem> items = Ds.GetItemsFiltered(filter);
            TListViewModel model = new();
            model.AddData(items, nTotal, filter);
            model.ErrorMessage = errorMessage;
            return Json(model, null);
            // return View("PartialViewList", model);
        }

        // =======================================
        // === Handle Errors
        // =======================================

        private IActionResult HandleError(Exception e) {
            ResponseData responseData = new();
            string text;
            if (e != null && !string.IsNullOrWhiteSpace(e.Message)) {
                text = e.Message;
            } else if (e != null) {
                text = e.ToString();
            } else {
                text = "Unknown error";
            }
            responseData.SetFail(text);
            return Json(responseData, null);
            // return View("PartialViewErrorMessage", responseData);
        }

        // ======================================================
        // Even if most things are identical in the controlling
        // of different entities, some things differ, these are 
        // handled by each entity controllers itself, but need
        // be declared here as abstract classes, if are used
        // from this class
        // ======================================================

        abstract protected TInputViewModel CreateViewModel(Person item);
        abstract protected void AddViewData(TInputViewModel model);
        abstract public void UpdateItemFromInput(TInputViewModel model, Person item);
    }
}
