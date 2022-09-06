using MVC_8.Models.Home;
using System.ComponentModel.DataAnnotations;

namespace MVC_8.Models.ViewModels {
    abstract public class DetailsViewModel {

        // Private Fields
        private EntityConst Entity { get; }
        private bool _isSuccess = true;
        private string _message = "";

        // Accessor Methods for private fields

        public string GetEntityCode() { return Entity.Code; }
        public bool IsSuccess() { return _isSuccess; }
        public string Message() { return _message; }

        // Properties

        [Required]
        public int Id { get; set; } = 0;

        [Display(Name = "Name")]
        [Required]
        public string Name { get; set; } = "";

        // Constructors

        protected DetailsViewModel(EntityConst entity) {
           Entity = entity;
        }

        protected DetailsViewModel(EntityConst entity, EntityItem item) {
            Entity = entity;
            Id = item.Id;
            Name = item.Name;
        }

        // Methods

        public DetailsViewModel AddResponseData(ResponseData responseData) {
            _isSuccess = responseData.IsSuccess;
            _message = responseData.Message;
            return this;
        }

        public DetailsViewModel AddFail(string str) {
            _isSuccess = false;
            _message = str;
            return this;
        }

        public DetailsViewModel AddSuccess(string str) {
            _isSuccess = true;
            _message = str;
            return this;
        }

        public string GetViewName() {
            return Entity.View;
        }

        // VIrtual Methods

        //virtual public void InitViewData(DataStore ds) {
        //}

        // Abstract Methods

        abstract public EntityItem GetItem(DataStore ds, bool getReferencedObjects = true);
    }
}
