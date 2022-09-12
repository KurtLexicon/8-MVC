namespace MVC_8.Models.ViewModels {
    public class UserInputViewModel {
        public string Id { get; set; } = "";
        public string Role { get; set; } = "";
        public FilterInputViewModel Filter { get; set; } = null!;
    }
}
