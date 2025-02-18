using Microsoft.AspNetCore.Mvc;
using DIExample.Services; // ✅ Make sure this is included

namespace DIExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMyService _myService;

        public HomeController(IMyService myService)
        {
            _myService = myService;
        }

        public IActionResult Index()
        {
            string message = _myService.GetMessage();
            ViewBag.Message = message;
            return View();
        }
    }
}
