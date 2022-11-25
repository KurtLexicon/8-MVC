
namespace MVC_8.Models {
    abstract public class ListViewModel {
        public EntityConst Entity { get; }
        public string[] Headers { get; }

        public string Filter { get; protected set; } = string.Empty;
        public IEnumerable<RowViewModel> Rows { get; protected set; } = new List<RowViewModel>();
        public int TotalCount { get; protected set; }
        public string ErrorMessage { get; set; } = "";

        protected ListViewModel(EntityConst entity, string[] headers) {
            Entity = entity;
            Headers = headers;
        }

        public void AddData(List<EntityItem> items, int totalCount, string filter) {
            Rows = items.Select(item => new RowViewModel(item.Id, RowValues(item)));
            TotalCount = totalCount;
            Filter = filter;
        }

        abstract protected string[] RowValues(EntityItem item);
    }
}
