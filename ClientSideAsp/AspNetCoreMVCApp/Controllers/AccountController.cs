using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVCApp.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Account/SignUp
        public IActionResult SignUp()
        {
            return View();
        }

        // POST: /Account/SignUp
        [HttpPost]
        public IActionResult SignUp(string Name, string Email, string Password)
        {
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
            {
                ViewBag.Error = "All fields are required.";
                return View();
            }
            // Here you would normally add sign-up logic.
            ViewBag.Message = "Sign-up successful!";
            return View();
        }
    }
}
