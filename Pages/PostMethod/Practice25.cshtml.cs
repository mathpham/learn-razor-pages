using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearnRazorPages.Pages{
    public class Practice25Model:PageModel{
        public string Country{get;private set;}
        public (string value, string display)[] Countries = new[]{
            ("Vietnam","Việt Nam"),
            ("Japan","Japan"),
            ("USA","United States of America"),
            ("Germany","Federal Republic of Germany")
        };
        public void OnPost(string country){
            Country = country;
        }
    }
}