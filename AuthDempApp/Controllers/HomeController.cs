using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthDemoApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        [Authorize]
        public IActionResult SecurePage() => View();

        [Authorize(Roles = "Admin")]
        public IActionResult AdminPage() => View();
    }
}
