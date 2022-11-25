
namespace MVC_8.Models {
    public class RowViewModel {
        public int Id { get; private set; }
        public string[] Values { get; private set; } = Array.Empty<string>();

        public RowViewModel(int id, string[] values) {
            Id = id;
            Values = values;
        }
    }
}
