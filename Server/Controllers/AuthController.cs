using FreeJob.Server.Models;
using FreeJob.Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FreeJob.Server.Controllers
{
    public class AuthController : Controller
    {
        private UserManager<ApplicationUser> _userManager { get; }

        public AuthController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public void LogIn()
        {

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(ApplicationUserModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = model.UserName, Email = model.Email, Type = model.Type };
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, model.Type.ToString());

                    Debug.WriteLine(model.Type.ToString());
                }
                else
                {
                    // Handle errors in result.Errors
                }
            }
            return View(model);
        }
    }
}
