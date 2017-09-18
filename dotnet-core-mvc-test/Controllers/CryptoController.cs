using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using dotnet_core_mvc_test.Models;

namespace MvcMovie.Controllers
{
    public class CryptoController : Controller
    {
        public CryptoController()
        {
            
        }

        // 
        // GET: /Crypto/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /Crypto/Welcome/ 

        public IActionResult Welcome(string name, int id = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["id"] = id;
            return View();
        }

        // 
        // GET: /Crypto/Hashing/ 
        public IActionResult Hashing()
        {
            ViewData["Algos"] = CryptoModel.HashingAlgorithms;
            return View();
        }
        
        // 
        // GET: /Crypto/Encryption/ 
        public IActionResult Encryption()
        {
            ViewData["Algos"] = CryptoModel.EncryptionAlgorithms;
            return View();
        }
        
        // 
        // POST: /Crypto/Hash/ 
        [HttpPost]
        public IActionResult Hash(string inputMd5Plain, string alg )
        {
            ViewData["md5Raw"] = inputMd5Plain;
            return View();
        }

        // 
        // POST: /Crypto/Encrypt/ 
        [HttpPost]
        public IActionResult Encrypt(string inputPlain, string algorithm)
        {
            ViewData["md5Raw"] = inputPlain;
            return Encryption();
        }
    }
}