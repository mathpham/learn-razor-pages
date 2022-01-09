using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearnRazorPages.Pages{
    public class Practice12Model : PageModel {
        [ViewData]
        public string Title {get;set;}
        public string Text {get;set;}
        public void OnGet(){
            var title = Request.Query["title"].ToString();
            Title = title
                    .Replace('-',' ')
                    .ToUpper();
            Text = "Test Object Request";
        }
    }
}