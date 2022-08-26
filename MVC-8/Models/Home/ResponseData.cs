namespace MVC_8.Models.Home {
    public class ResponseData {
        public string Message { get; private set; } = string.Empty;
        public bool IsSuccess { get; private set; } = true;

        public void SetFail(string message) {
            Message = message;
            IsSuccess = false;
        }
        public void SetSuccess(string message) {
            Message = message;
            IsSuccess = true;
        }
    }
}
