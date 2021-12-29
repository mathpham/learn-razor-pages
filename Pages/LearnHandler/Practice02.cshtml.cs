using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearnRazorPages.Pages{
    public class Practice02Model : PageModel{
        public string Message{get;set;}
        public void OnGet(){
            Message = "This is a GET Request!";
        }
        public void OnPost(){
            Message = "This is a POST Request";
        }
    }
}