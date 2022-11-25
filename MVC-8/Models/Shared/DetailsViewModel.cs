using System.ComponentModel.DataAnnotations;

namespace MVC_8.Models {
    abstract public class DetailsViewModel {
        // Private Fields
        private EntityConst Entity { get; }
        private bool _isSuccess = true;
        private string _message = "";

        // Accessor Methods for private fields
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

        public DetailsViewModel AddFail(string str) {
            _isSuccess = string.IsNullOrEmpty(str);
            _message = str;
            return this;
        }

        public DetailsViewModel AddSuccess(string str) {
            _isSuccess = true;
            _message = str;
            return this;
        }
    }
}
