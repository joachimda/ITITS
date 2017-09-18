using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Security.Web.ViewModels;

namespace Security.Web.Controllers
{
    public class HashingController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = CreateHashingViewModel();

            return View(viewModel);
        }

        private static HashingViewModel CreateHashingViewModel()
        {
            return new HashingViewModel
            {
                Algorithms = new List<string> { "MD5", "SHA1", "SHA256", "SHA384", "SHA512" }
            };
        }

        public IActionResult GenerateHash(HashingViewModel model)
        {
            // Get values here
            model = CreateHashingViewModel();
            model.CipherText = "Derp herp oij oij";
            return View(nameof(Index), model);
        }
    }
}