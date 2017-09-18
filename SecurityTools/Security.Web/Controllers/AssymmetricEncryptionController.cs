using Microsoft.AspNetCore.Mvc;

namespace Security.Web.Controllers
{
    public class AssymmetricEncryptionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}