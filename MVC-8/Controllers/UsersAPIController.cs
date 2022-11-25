using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MVC_8.Data;
using MVC_8.Models;


namespace MVC_8.Controllers
{

    public class UsersAPIController : Controller
    {
        static readonly private string[] staticUsers = new string[] {
            "admin@admin.com"
        };

        private ApplicationDbContext DbContext { get; } = null!;
        readonly RoleManager<IdentityRole> _roleManager;
        readonly UserManager<ApplicationUser> _userManager;
        readonly SignInManager<IdentityUser> _signInManager;

        public UsersAPIController(
            ApplicationDbContext dbContext,
            RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager,
            SignInManager<IdentityUser> signInManager
            )
        {
            DbContext = dbContext;
            _roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // =======================================
        // Get List
        // =======================================

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<JsonResult> GetList(string filterText, string category)
        {
            try
            {
                List<UserWithRoles> items = await GetUserList(filterText, category);
                return Json(items);
            }
            catch (Exception e)
            {
                return Json(new ErrorResponse(e));
            }
        }

        // =======================================
        // Update Role for User
        // =======================================

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<JsonResult> UpdateRole([FromBody] string id, string role)
        {
            try
            {
                string[] allRoles = new[] { "Admin", "User" };
                var user = await _userManager.FindByIdAsync(id);

                if (IsUnchangable(user.Email))
                {
                    throw new InfoException($"User {user.Email} can not be changed or removed");
                }

                (await
                    _userManager.GetRolesAsync(user))
                        .Where(r => r != role)
                        .ToList()
                        .ForEach(async r => await _userManager.RemoveFromRoleAsync(user, r)
                );

                await _userManager.AddToRoleAsync(user, role);

                UserWithRoles userWithRoles = await AddRoles(user);
                return Json(userWithRoles, null);
            }
            catch (Exception e)
            {
                return Json(new ErrorResponse(e));
            }
        }

        // =======================================
        // UpdateUser
        // =======================================
        [HttpPost]
        public async Task<JsonResult> UpdateUser([FromBody] ApplicationUser input)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(input.Id);
                user.Email = input.Email;
                user.NormalizedEmail = input.Email.Normalize();
                user.UserName = input.Email;
                user.NormalizedUserName = input.Email.Normalize();
                user.FirstName = input.FirstName;
                user.LastName = input.LastName;
                user.BirthDate = input.BirthDate;
                await _userManager.UpdateAsync(user);
                return Json(new { }, null);
            }
            catch (Exception e)
            {
                return Json(new ErrorResponse(e));
            }
        }

        // =======================================
        // Register User
        // =======================================

        // A user with role user can be created by anyone, even someone not logged in

        [HttpPost]
        public async Task<IActionResult> Register([FromBody]
            string email,
            string firstName,
            string lastName,
            DateTime birthDate,
            string password
        )
        {
            try
            {
                ApplicationUser user = new() {
                    Email = email,
                    NormalizedEmail = email.Normalize(),
                    UserName = email,
                    NormalizedUserName = email.Normalize(),
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = birthDate,
                };

                IdentityResult resultCreate = await _userManager.CreateAsync(user, password);
                if (!resultCreate.Succeeded)
                {
                    throw new InfoException(resultCreate.ToString());
                }

                IdentityResult resultSetRole = await _userManager.AddToRoleAsync(user, "User");
                if (!resultSetRole.Succeeded)
                {
                    throw new InfoException(resultSetRole.ToString());
                }

                UserWithRoles userWithRoles = await AddRoles(user);
                return Json(userWithRoles, null);
            }
            catch (Exception e)
            {
                return Json(new ErrorResponse(e));
            }
            // var token = await _userManager.GetAuthenticationTokenAsync(user, TokenOptions.DefaultProvider, "AuthToken");
        }

        // =======================================
        // Login user
        // =======================================

        public class LoginViewModel
        {
            public string Login { get; set; } = "";
            public string Password { get; set; } = "";
            public bool RememberMe { get; set; }
        }

        [HttpPost]
        public async Task<JsonResult> Login(LoginViewModel user)
        {
            try
            {
                if (!ModelState.IsValid)
                    throw new Exception("Login failed");
                var resultLogin = await _signInManager.PasswordSignInAsync(user.Login, user.Password, user.RememberMe, false);
                if (!resultLogin.Succeeded)
                    throw new Exception("Login failed");
                return Json(user, null);
            }
            catch (Exception e)
            {
                return Json(new ErrorResponse(e));
            }
        }

        // =======================================
        // Delete user
        // =======================================

        [Authorize(Roles = "Admin")]
        [HttpDelete]
        public async Task<JsonResult> DeleteItem(string id)
        {

            try
            {
                var user = await _userManager.FindByIdAsync(id);
                if (user == null)
                    throw new InfoException("User can not be found");

                if (IsUnchangable(user.Email))
                {
                    throw new InfoException($"User {user.Email} can not be changed or removed");
                }
                var userRoles = await _userManager.GetRolesAsync(user);
                foreach (string role in userRoles)
                {
                    IdentityResult resultRemoveRole = await _userManager.RemoveFromRoleAsync(user, role);
                    if (!resultRemoveRole.Succeeded)
                    {
                        throw new InfoException(resultRemoveRole.ToString());
                    }
                }
                IdentityResult result = await _userManager.DeleteAsync(user);
                if (!result.Succeeded)
                {
                    throw new InfoException(result.ToString());
                }
                return Json(new { }, null);
            }
            catch (Exception e)
            {
                return Json(new ErrorResponse(e));
            }
        }

        // =======================================
        // Login User
        // =======================================

        // =======================================
        // Helpers
        // =======================================

        private async Task<UserWithRoles> AddRoles(ApplicationUser user)
        {
            var roles = (await _userManager.GetRolesAsync(user)).ToList();
            var userWithROles = new UserWithRoles(user, roles);
            return userWithROles;
        }

        private async Task<UserListViewModel> DoGetItems(FilterInputViewModel filter)
        {
            return await DoGetItems(filter.FilterText, filter.Category);
        }

        public async Task<List<UserWithRoles>> GetUserList(string filterText, string category)
        {
            List<ApplicationUser> users = new();
            users.AddRange(
                string.IsNullOrEmpty(filterText) ?
                _userManager.Users :
                _userManager.Users.Where(u =>
                    u.FirstName.Contains(filterText) ||
                    u.LastName.Contains(filterText) ||
                    u.Email.Contains(filterText)
                )
            );

            // Yes this is stupid, i can't figure out how should do otherwise, though

            Dictionary<string, List<string>> dic = new();
            foreach (ApplicationUser user in users)
            {
                dic.Add(user.Id, (await _userManager.GetRolesAsync(user)).ToList());
            }

            var usersWithRoles = users.Select(u => new UserWithRoles(u, dic[u.Id]));

            if (!string.IsNullOrWhiteSpace(category))
            {
                usersWithRoles = usersWithRoles.Where(u => u.Roles.Contains(category));
            }
            return usersWithRoles.ToList();
        }

        public async Task<UserListViewModel> DoGetItems(string filterText, string category)
        {
            int nTotal = _userManager.Users.Count();
            var usersWithRoles = await GetUserList(filterText, category);
            UserListViewModel model = new();
            model.AddData(usersWithRoles, nTotal, filterText, category);
            return model;
        }

        private static bool IsUnchangable(string email)
        {
            return staticUsers.Contains(email.ToLower());
        }
    }
}
