using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearnRazorPages.Pages{
    public class Practice24Model : PageModel{
        public string Language {get;private set;}
        public string[] OfficialLanguages => new[]{
            "Arabic",
            "Chinese",
            "English",
            "French",
            "Russian",
            "Spanish"
        };
        public void OnPost(string language){
            Language = language;
        }
    }
}