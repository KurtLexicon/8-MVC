namespace MVC_8.Models.Home {
    abstract public class ItemRowViewModel {
        abstract public string EntityCode { get; }
        public int Id { get;}
        public string[] Values { get;} = Array.Empty<string>();

        protected ItemRowViewModel(EntityItem item) {
            Id = item.Id;
            Values = item.GetRowValues();
        }
    }
}
