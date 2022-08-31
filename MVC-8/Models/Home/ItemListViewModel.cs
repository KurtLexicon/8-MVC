namespace MVC_8.Models.Home {
    abstract public class ItemListViewModel {
        abstract public string EntityCode { get; }
        public string EntityName { get; }
        public string EntitiesName { get; }
        public string[] Headers { get; }
        public List<ItemRowViewModel> ItemRows { get; }
        public bool CanCreateRandom { get; }
        public int TotalCount { get; }
        public string Filter { get; }
        public string ErrorMessage { get; set; } = "";

        protected ItemListViewModel(string entityName, string entitiesName, int totalCount, string filter, string[] headers, List<ItemRowViewModel> itemRows, bool canCreateRandom = false) {
            EntityName = entityName;
            EntitiesName = entitiesName;
            Headers = headers;
            ItemRows = itemRows;
            CanCreateRandom = canCreateRandom;
            TotalCount = totalCount;
            Filter = filter;
        }
    }
}
