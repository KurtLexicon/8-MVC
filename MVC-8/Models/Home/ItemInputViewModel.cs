using System.ComponentModel.DataAnnotations;

namespace MVC_8.Models.Home {
    abstract public class ItemInputViewModel {

        // Private Fields

        private string _entityCode;
        private bool _isSuccess = true;
        private string _message = "";
        private string _partialViewName = "";

        // Accessor Methods for private fields

        public string GetEntityCode() { return _entityCode; }
        public bool IsSuccess() { return _isSuccess; }
        public string Message() { return _message; }

        protected void SetEntityCode(string entityCode) { _entityCode = entityCode; }

        // Properties

        [Required]
        public int Id { get; set; } = 0;

        [Display(Name = "Name")]
        [Required]
        public string Name { get; set; } = "";

        // Constructors

        protected ItemInputViewModel(string entityCode) {
            _entityCode = entityCode;
        }

        protected ItemInputViewModel(EntityItem item) {
            _entityCode = item.GetEntityCode();
            Id = item.Id;
            Name = item.Name;
            _partialViewName = item.GetPartialViewName();
        }

        protected ItemInputViewModel(EntityItem item, ResponseData responseData) {
            Id = item.Id;
            Name = item.Name;
            _entityCode = item.GetEntityCode();
            _isSuccess = responseData.IsSuccess;
            _message = responseData.Message;
            _partialViewName = item.GetPartialViewName();
        }

        // Methods

        public string GetViewName() {
            return _partialViewName;
        }

        public ItemInputViewModel AddResponseData(ResponseData responseData) {
            _isSuccess = responseData.IsSuccess;
            _message = responseData.Message;
            return this;
        }

        public ItemInputViewModel AddFail(string str) {
            _isSuccess = false;
            _message = str;
            return this;
        }

        public ItemInputViewModel AddSuccess(string str) {
            _isSuccess = true;
            _message = str;
            return this;
        }

        virtual public void InitViewData(DataStore ds) {
            EntityItem item = GetItem(ds, false);
            _partialViewName = item.GetPartialViewName();
            SetEntityCode(item.GetEntityCode());
        }

        // Abstract Methods

        abstract public EntityItem GetItem(DataStore ds, bool getReferencedObjects = true);

    }
}
