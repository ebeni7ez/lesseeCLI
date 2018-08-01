using LesseeClient.Caller.Callers;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LesseeClient.Controllers
{
    public class LeasesController : Controller
    {
        // GET: /Leases/
        public IActionResult Index(string active)
        {
            var caller = new RestSharpCaller(Constants.baseUrl);
            var leases = caller.GetLeases(active);
            ViewBag.leases = leases;

            return View();
        }
    }
}
