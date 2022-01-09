using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearnRazorPages.Pages{
    public class Practice11Model : PageModel {
        [ViewData]
        public string Title {get;set;}
        public string Text {get;set;}
        public void OnGet(string title){ // tham số title là biến trong url /?title=hello-world
            //title = RouteData.Values["title"].ToString();
            Title = title
                    .Replace('-',' ')
                    .ToUpper();
            Text = "Query String Test";
        }
    }
}