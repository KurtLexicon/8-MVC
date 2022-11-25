
namespace MVC_8.Models {
    public class UserListViewModel {
        public EntityConst Entity { get; }
        public string[] Headers { get; }

        public string Filter { get; protected set; } = string.Empty;
        public string RoleFilter { get; protected set; } = string.Empty;

        public IEnumerable<UserRowViewModel> Rows { get; protected set; } = new List<UserRowViewModel>();
        public int TotalCount { get; protected set; }
        public string ErrorMessage { get; set; } = "";

        public UserListViewModel() {
            Entity = Const.User;
            Headers = new string[] { "Name", "E-mail", "Role" };
        }

        public void AddData(IEnumerable<UserWithRoles> items, int totalCount, string filter, string rowFilter) {
            Rows = items.Select(item => new UserRowViewModel(item.User.Id, RowValues(item)));
            TotalCount = totalCount;
            Filter = filter;
            RoleFilter = rowFilter;
        }

        private string[] RowValues(UserWithRoles user) {
            return new string[] {
                $"{user.User.FirstName} {user.User.LastName}",
                user.User.Email,
                SignificantRole(user.Roles) };
        }

        private string SignificantRole(List<string> roles) {
            List<string> rolesOrdered = new() { "Admin", "User" };
            return rolesOrdered.Find(role => roles.Contains(role)) ?? "None";
        }
    }
}
