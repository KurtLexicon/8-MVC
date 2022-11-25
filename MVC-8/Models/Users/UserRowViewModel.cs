namespace MVC_8.Models {
    public class UserRowViewModel {
        public string Id { get; private set; }
        public string[] Values { get; private set; } = Array.Empty<string>();

        public UserRowViewModel(string id, string[] values) {
            Id = id;
            Values = values;
        }
    }
}
