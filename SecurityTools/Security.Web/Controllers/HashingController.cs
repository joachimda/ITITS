using Microsoft.AspNetCore.Mvc;

namespace Security.Web.Controllers
{
    public class HashingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}