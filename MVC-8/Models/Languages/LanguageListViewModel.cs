
namespace MVC_8.Models {
    public class LanguageListViewModel : ListViewModel {
        public LanguageListViewModel() : base(Const.Language, _rowHeaders) { }

        static readonly string[] _rowHeaders = new string[] {
            "Id",
            "Name" 
        };

        override protected string[] RowValues(EntityItem item) {
            return new string[] { 
                item.Id.ToString(), 
                item.Name
            };
        }
    }
}
