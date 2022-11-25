
namespace MVC_8.Models {
    public class CountryListViewModel : ListViewModel {
        static readonly string[] _rowHeaders = new string[] { "Id", "Name" };

        public CountryListViewModel() : base(Const.Country, _rowHeaders) { }

        override protected string[] RowValues(EntityItem item) {
            return new string[] { item.Id.ToString(), item.Name };
        }
    }
}
