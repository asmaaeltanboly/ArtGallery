using Art_Gallery.ViewModels;
using DataAccessLayer.Entities.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Art_Gallery.Controllers.Account
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AccountController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SaveRegister(RegisterViewModel UserViewModel)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser
                {
                    UserName = UserViewModel.UserName,
                    Email = UserViewModel.Email
                };

                // Identity بيشفر كلمة السر تلقائياً
                var result = await _userManager.CreateAsync(user, UserViewModel.PassWord);

                if (result.Succeeded)
                {
                    // نجح التسجيل - ممكن تعمل redirect
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // في أخطاء - اعرضها للمستخدم
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }

            return View("Register", UserViewModel);
        }
    }
}