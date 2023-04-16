using System.Web;

namespace Gurung2English.Pages
{
    public class Translate
    {
        public string GurungKey { get; set; }
        public string EnglishValue { get; set; }
        public string NepaliValue { get; set; }
        public string Description { get; set; }
        public string PronunciationKey { get; set; }

         public string PronunciationLink { get; set; }
        //public string PronunciationLink { get; set; } = "https://translate.google.com/?tl=ne&text=tamu%20ky%C4%AB&op=pronunciation";
    }
}
