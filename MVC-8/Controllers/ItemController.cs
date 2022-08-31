using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_8.Data;
using MVC_8.Models.Home;

namespace MVC_8.Controllers {
    abstract public class ItemController<TItem, TViewModel, TInputViewModel> : Controller
        where TItem : EntityItem, new()
        where TViewModel : ItemListViewModel
        where TInputViewModel : ItemInputViewModel {

        protected DataStoreItem<TItem> Ds { get; set; }

        protected ItemController(ApplicationDbContext dbContext, DbSet<TItem> dbSet) : base() {
            Ds = new(dbContext, dbSet);
        }

        // =======================================
        // Get Items
        // =======================================

        [HttpPost]
        public ActionResult GetItems([FromBody] string filter) {
            try {
                int nTotal = Ds.GetNumberOfItems();
                List<TItem> items = Ds.GetItemsFiltered(filter);
                List<EntityItem> entitytems = items.Select(i => (EntityItem)i).ToList();
                ItemListViewModel model = new TItem().GetItemListViewModel(entitytems, nTotal, filter);
                return View("PartialViewItemList", model);
            }
            catch (Exception e) {
                return HandleError(e);
            }
        }

        // =======================================
        // Get Item
        // =======================================

        [HttpPost]
        public IActionResult GetItem([FromBody] int id) {
            try {
                ResponseData responseData = new();

                TItem item;
                if (id == 0) {
                    item = new();
                } else {
                    try {
                        item = Ds.GetItemById(id);
                    }
                    catch (DataStore.ItemNotFoundException) {
                        item = new();
                        responseData.SetFail($"{item.GetEntityCode()} {id} not found");
                    }
                }

                ItemInputViewModel model = item.GetItemInputViewModel(Ds);
                model.AddResponseData(responseData);
                return View("PvDetail", model);
            }
            catch (Exception e) {
                return HandleError(e);
            }
        }

        // =======================================
        // === Add or Update Item
        // =======================================

        [HttpPost]
        public IActionResult AddOrUpdateItem([FromBody] TInputViewModel input) {
            ItemInputViewModel model;
            try {
                if (!ModelState.IsValid) throw new DataStore.InfoException("Please enter valid data");

                if (input.Id == 0) {

                    // Add new item from valid input

                    EntityItem entityItem = input.GetItem(Ds);
                    if (entityItem is not TItem) throw new Exception("Program error: TInputViewModel.GetItem did not return TItem");
                    TItem item = Ds.AddItem((TItem)entityItem);
                    model = item.GetItemInputViewModel(Ds);
                    model.AddSuccess($"{item.GetEntityCode()} {item.Id} added");

                } else {

                    // Update existing item from valid input

                    try {
                        TItem item = Ds.UpdateItem(input);
                        model = item.GetItemInputViewModel(Ds);
                        model.AddSuccess($"{item.GetEntityCode()} {item.Id} updated");
                    }
                    catch (DataStore.ItemNotFoundException) {
                        TItem item = new();
                        throw new DataStore.InfoException($"{item.GetEntityCode()} {input.Id} not found");
                    }
                }
            }

            catch (DataStore.InfoException ex) {
                model = input;
                model.InitViewData(Ds);
                model.AddFail(ex.Message);
            }

            return View("PvDetail", model);
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
            catch (DataStore.InfoException ex) {
                errorMessage = ex.Message;
            }

            int nTotal = Ds.GetNumberOfItems();
            List<TItem> items = Ds.GetItemsFiltered(filter);
            List<EntityItem> entitytems = items.Select(i => (EntityItem)i).ToList();
            ItemListViewModel model = new TItem().GetItemListViewModel(entitytems, nTotal, filter);
            model.ErrorMessage = errorMessage;
            return View("PartialViewItemList", model);
        }

        // =======================================
        // === Handle Errors
        // =======================================

        private ViewResult HandleError(Exception e) {
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
            return View("PartialViewErrorMessage", responseData);
        }
    }
}
