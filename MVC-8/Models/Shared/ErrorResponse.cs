namespace MVC_8.Models {
    public class ErrorResponse {
        public string ErrText { get;}

        public ErrorResponse(Exception e)
        {
            if(e is DataStore.ItemNotFoundException)
            {
                ErrText = "Not Found";
            }
            if (e != null && !string.IsNullOrWhiteSpace(e.Message))
            {
                ErrText = e.Message;
            }
            else if (e != null)
            {
                ErrText = e.ToString();
            }
            else
            {
                ErrText = "Unknown error";
            }
        }
    }
}
