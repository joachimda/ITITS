using Microsoft.AspNetCore.Mvc;

namespace Security.Web.Controllers
{
    public class SymmetricEncryptionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}