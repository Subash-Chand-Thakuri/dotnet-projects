using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StateManagementApp.Controllers
{
    public class StateController : Controller
    {
        // Index Action - Main Page
        public IActionResult Index()
        {
            return View();
        }

        // *** SESSION STATE ***
        public IActionResult SetSession()
        {
            HttpContext.Session.SetString("UserName", "John Doe");
            return RedirectToAction("GetSession");
        }

        public IActionResult GetSession()
        {
            string userName = HttpContext.Session.GetString("UserName") ?? "No session value set";
            ViewBag.Message = "Session Value: " + userName;
            return View("Result");
        }

        // *** HTTP CONTEXT ***
        public IActionResult SetHttpContext()
        {
            HttpContext.Items["AppData"] = "Data stored in HttpContext";
            return RedirectToAction("GetHttpContext");
        }

        public IActionResult GetHttpContext()
        {
            string data = HttpContext.Items["AppData"]?.ToString() ?? "No data in HttpContext";
            ViewBag.Message = "HttpContext Value: " + data;
            return View("Result");
        }

        // *** TEMP DATA ***
        public IActionResult SetTempData()
        {
            TempData["Notification"] = "This is a TempData message!";
            return RedirectToAction("GetTempData");
        }

        public IActionResult GetTempData()
        {
            ViewBag.Message = "TempData Value: " + TempData["Notification"];
            return View("Result");
        }

        // *** COOKIES ***
        public IActionResult SetCookie()
        {
            Response.Cookies.Append("UserEmail", "user@example.com");
            return RedirectToAction("GetCookie");
        }

        public IActionResult GetCookie()
        {
            string email = Request.Cookies["UserEmail"] ?? "No cookie found";
            ViewBag.Message = "Cookie Value: " + email;
            return View("Result");
        }

        // *** QUERY STRINGS ***
        public IActionResult QueryStringExample(string user)
        {
            ViewBag.Message = "Query String Value: " + (user ?? "No query string provided");
            return View("Result");
        }

        // *** HIDDEN FIELD ***
        [HttpPost]
        public IActionResult HiddenFieldExample(string hiddenValue)
        {
            ViewBag.Message = "Hidden Field Value: " + hiddenValue;
            return View("Result");
        }
    }
}
