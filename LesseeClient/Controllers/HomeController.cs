using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LesseeClient.Models;
using LesseeClient.Caller.Callers;

namespace LesseeClient.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        public IActionResult Index(string message, string errorMsg)
        {
            var caller = new RestSharpCaller(Constants.baseUrl);
            var platforms = caller.GetPlatforms();
            ViewBag.platforms = platforms;
            ViewBag.message = message;
            ViewBag.errorMsg = errorMsg;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
