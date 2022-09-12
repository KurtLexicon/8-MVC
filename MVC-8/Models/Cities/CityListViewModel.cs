using MVC_8.Models.Home;

namespace MVC_8.Models.ViewModels {
    public class CityListViewModel : ListViewModel {
        public CityListViewModel() : base(Const.City, _rowHeaders) { }

        static readonly string[] _rowHeaders = new string[] {
            "Id",
            "Name",
            "Country" };

        override protected string[] RowValues(EntityItem item) {
            City city = (City)item;
            return new string[] {
                item.Id.ToString(), 
                city.Name, 
                city.Country.Name 
            };
        }
    }
}
