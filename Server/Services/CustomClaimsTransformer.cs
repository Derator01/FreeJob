//using FreeJob.Server.Models;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;

//public class AccountController : Controller
//{
//    private readonly UserManager<ApplicationUser> _userManager;

//    public AccountController(UserManager<ApplicationUser> userManager)
//    {
//        _userManager = userManager;
//    }

//    public async Task<IActionResult> Register(RegisterModel model)
//    {
//        // ... validate model and other registration logic ...

//        var user = new ApplicationUser { UserName = model.Email, Email = model.Email };

//        var result = await _userManager.CreateAsync(user, model.Password);

//        if (result.Succeeded)
//        {
//            // Assign roles to the user here
//            await _userManager.AddToRoleAsync(user, "YourRole");

//            // ... other registration success logic ...
//        }
//        else
//        {
//            // Handle errors if user creation fails
//        }
//    }
//}
