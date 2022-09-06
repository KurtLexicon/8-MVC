using MVC_8.Models.Home;

namespace MVC_8.Models.ViewModels {
    public class CityListViewModel : ListViewModel {
        static readonly string[] _rowHeaders = new string[] { "Id", "Name", "Country" };

        public CityListViewModel() : base(Const.Language, _rowHeaders) { }

        override protected string[] RowValues(EntityItem item) {
            City city = (City)item;
            return new string[] { item.Id.ToString(), item.Name, city.Country.Name };
        }
    }
}
