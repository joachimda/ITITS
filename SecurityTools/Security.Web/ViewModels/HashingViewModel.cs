using System.Collections.Generic;

namespace Security.Web.ViewModels
{
    public class HashingViewModel
    {
        public string PlainText { get; set; }
        public string CipherText { get; set; }
        public string SelectedAlgorithm { get; set; }
        public List<string> Algorithms { get; set; }
        public string Salt { get; set; }
    }
}