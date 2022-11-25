using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MVC_8.Data;
using MVC_8.Models;


namespace MVC_8.Controllers
{

    public class UsersController : Controller
    {
        static readonly private string[] staticUsers = new string[] {
            "admin@admin.com"
        };

        private ApplicationDbContext DbContext { get; } = null!;
        readonly RoleManager<IdentityRole> _roleManager;
        readonly UserManager<ApplicationUser> _userManager;

        public UsersController(ApplicationDbContext dbContext, RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            DbContext = dbContext;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        // =======================================
        // Index Page
        // =======================================

        [Authorize(Roles = "Admin")]
        public ViewResult Index()
        {
            return View(new PageViewModel(Const.User));
        }

        // =======================================
        // Get users
        // =======================================

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<PartialViewResult> GetList(string filterText, string category)
        {
            UserListViewModel model = await DoGetItems(filterText, category);
            return PartialView(model);
        }

        // =======================================
        // Update Role for User
        // =======================================

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<PartialViewResult> UpdateRole([FromBody] UserInputViewModel input)
        {
            try
            {
                string[] allRoles = new[] { "Admin", "User" };
                var user = await _userManager.FindByIdAsync(input.Id);

                if (IsUnchangable(user.Email))
                {
                    throw new InfoException($"User {user.Email} can not be changed or removed");
                }

                (await
                    _userManager.GetRolesAsync(user))
                        .Where(r => r != input.Role)
                        .ToList()
                        .ForEach(async r => await _userManager.RemoveFromRoleAsync(user, r)
                );

                await _userManager.AddToRoleAsync(user, input.Role);

                UserListViewModel model = await DoGetItems(input.Filter);
                return PartialView(model);
            }
            catch (InfoException ex)
            {
                UserListViewModel model = await DoGetItems(input.Filter);
                model.ErrorMessage = ex.Message;
                return PartialView(model);
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
            ApplicationUser user = new ApplicationUser() {
                Email = email,
                NormalizedEmail = email.Normalize(),
                UserName = email,
                NormalizedUserName = email.Normalize(),
                FirstName = firstName,
                LastName=lastName,  
                BirthDate=birthDate,
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

            return Redirect("/About");

            // var token = await _userManager.GetAuthenticationTokenAsync(user, TokenOptions.DefaultProvider, "AuthToken");
        }
        // =======================================
        // Delete user
        // =======================================

        [Authorize(Roles = "Admin")]
        [HttpDelete]
        public async Task<PartialViewResult> DeleteItem(string id)
        {
            string errorMessage = "";

            try
            {
                var user = await _userManager.FindByIdAsync(id);
                if (user != null)
                {
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
                }
            }
            catch (InfoException ex)
            {
                errorMessage = ex.Message;
            }
            SharedViewModel model = new(errorMessage);
            return PartialView(model);
        }

        // =======================================
        // Login User
        // =======================================

        // =======================================
        // Helpers
        // =======================================

        private async Task<UserListViewModel> DoGetItems(FilterInputViewModel filter)
        {
            return await DoGetItems(filter.FilterText, filter.Category);
        }

        //public UserListViewModel DoGetList(string filterText, string category)
        //{
        //    int nTotal = _userManager.Users.Count();
        //    List<ApplicationUser> users = new();
        //    users.AddRange(
        //        string.IsNullOrEmpty(filterText) ?
        //        _userManager.Users :
        //        _userManager.Users.Where(u =>
        //            u.FirstName.Contains(filterText) ||
        //            u.LastName.Contains(filterText) ||
        //            u.Email.Contains(filterText)
        //        )
        //    );
        //}

        public async Task<UserListViewModel> DoGetItems(string filterText, string category)
        {
            int nTotal = _userManager.Users.Count();

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
