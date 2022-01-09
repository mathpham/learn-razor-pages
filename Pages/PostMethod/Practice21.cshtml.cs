using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearnRazorPages.Pages{
    public class Practice21Model : PageModel{
        public string Title {get;private set;}
        public string Text {get; private set;}

        public void OnPost(string title, string text){
            Title = title;
            //Or: Title = Request.Form["title"];
            Text = text;
            //Or: Text = Request.Form["text"];
        }
    }
}