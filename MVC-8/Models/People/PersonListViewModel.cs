
namespace MVC_8.Models {
    public class PersonListViewModel : ListViewModel {
        static readonly string[] _rowHeaders = { "Id", "Name", "Phone", "City" };

        public PersonListViewModel() : base(Const.Person, _rowHeaders) { }

        override protected string[] RowValues(EntityItem item) {
            Person person = (Person)item;
            return new string[] { item.Id.ToString(), item.Name, person.Phone, person.City.Name };
        }
    }
}
