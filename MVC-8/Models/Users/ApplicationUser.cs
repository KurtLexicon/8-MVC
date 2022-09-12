using Microsoft.AspNetCore.Identity;

namespace MVC_8.Models {
    public class ApplicationUser : IdentityUser {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
    }
}
