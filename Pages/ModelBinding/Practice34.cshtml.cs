using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearnRazorPages.Pages{
    public class Practice34Model : PageModel {
        [BindProperty(SupportsGet = true)]
        public string fullName{get;set;}
        [BindProperty(SupportsGet = true)]
        public string eMail{get;set;}
        [BindProperty(SupportsGet = true)]
        public int Age {get; set;}
        public string Message {get;private set;}

        public void OnGet() => Message = Age <18?
        $"Sorry, {fullName}. You cannot subcribe for our site" :
        $"Hello, {fullName}. Thank you for your subcription. We will send email to the address '{eMail}'. ";
    }
}