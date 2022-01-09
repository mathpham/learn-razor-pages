using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearnRazorPages.Pages{
    public class Practice23Model : PageModel{
        public List<string> Languages{get;private set;}
        public string[] OfficialLanguages = new[]{
            "Arabic",
            "Chinese",
            "English",
            "French",
            "Russian",
            "Spanish"
        };
        public void OnPost(List<string> languages){
            Languages = languages;
        }
    }
}