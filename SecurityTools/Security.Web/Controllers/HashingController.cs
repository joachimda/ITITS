using System.Collections.Generic;
using HashingToolkit;
using Microsoft.AspNetCore.Mvc;
using Security.Web.ViewModels;

namespace Security.Web.Controllers
{
    public class HashingController : Controller
    {
        private readonly IHashifier _hashifier;

        public HashingController(IHashifier hashifier)
        {
            _hashifier = hashifier;
        }

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
            var hash = _hashifier.Hashify(model.SelectedAlgorithm, model.PlainText, model.Salt);
            model = CreateHashingViewModel();
            model.CipherText = hash;
            return View(nameof(Index), model);
        }
    }
}