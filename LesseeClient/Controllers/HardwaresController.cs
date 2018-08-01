using Microsoft.AspNetCore.Mvc;
using LesseeClient.Caller.Callers;


namespace LesseeClient.Controllers
{
    public class HardwaresController : Controller
    {
        // GET: /Hardwares/
        public IActionResult Index(string message, string platform)
        {
            var caller = new RestSharpCaller(Constants.baseUrl);
            var platforms = caller.GetPlatforms();
            var hardwares = caller.GetHardwares(platform);
            ViewBag.hardwares = hardwares;
            ViewBag.platforms = platforms;
            ViewBag.message = message;   

            return View();
        }

        // GET: /Hardwares/Add/
        public IActionResult Add()
        {
            var caller = new RestSharpCaller(Constants.baseUrl);
            var platforms = caller.GetPlatforms();
            return View(platforms);
        }
    }
}
