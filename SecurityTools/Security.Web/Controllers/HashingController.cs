using Microsoft.AspNetCore.Mvc;
using Security.Web.ViewModels;

namespace Security.Web.Controllers
{
    public class HashingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public void GenerateHash(HashingViewModel hvm)
        {
            var a = hvm.CipherText;
            var b = hvm.PlainText;

        }
    }
}