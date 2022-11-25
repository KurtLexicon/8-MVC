namespace MVC_8.Models {
    public class SharedViewModel {
        // Private Fields

        private bool _isSuccess = true;
        private string _message = "";

        // Constructor

        public SharedViewModel(string errorMessage = "") {
            AddFail(errorMessage);
        }

        // Accessor Methods for private fields

        public bool IsSuccess() { return _isSuccess; }
        public string Message() { return _message; }

        // Methods

        public SharedViewModel AddFail(string str) {
            _isSuccess = string.IsNullOrWhiteSpace(str);
            _message = str;
            return this;
        }

        public SharedViewModel AddSuccess(string str) {
            _isSuccess = true;
            _message = str;
            return this;
        }
    }
}
