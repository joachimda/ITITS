using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Security.Web.ViewModels
{
    public class HashingViewModel
    {
        [Display(Name = "Plain")]
        public string PlainText { get; set; }

        [Display(Name = "Cipher")]
        public string CipherText { get; set; }
        
        [Display(Name = "Algorithm")]
        public string SelectedAlgorithm { get; set; }
        
        [Display(Name = "Algorithme Selection")]
        public List<string> Algorithms { get; set; }

        [Display(Name = "Use salt?")]
        public string Salt { get; set; }
    }
}