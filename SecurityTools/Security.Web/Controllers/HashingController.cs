using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Security.Web.ViewModels;

namespace Security.Web.Controllers
{
    public class HashingController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new HashingViewModel
            {
                Algorithms = new List<string> { "MD5", "SHA1", "SHA256", "SHA384", "SHA512" }
            };

            return View(viewModel);
        }

        public void GenerateHash(HashingViewModel model)
        {
            var selectedAlgorithm = model.SelectedAlgorithm;
        }
    }
}