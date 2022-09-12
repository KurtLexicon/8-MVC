namespace MVC_8.Models {
    public class UserWithRoles {
        public ApplicationUser User { get; set; }
        public List<string> Roles { get; set; } = new();
        public UserWithRoles(ApplicationUser user, List<string> roles) {
            User = user;
            Roles = roles;
        }
    }
}
