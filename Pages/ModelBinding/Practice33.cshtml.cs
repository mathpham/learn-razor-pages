using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearnRazorPages.Pages{
    public class Practice33Model : PageModel {
        public string Message{get;set;}
        public void OnGet(string fullName, string eMail, int age) =>Message = age <18?
        $"Sorry, {fullName}. You cannot subcribe for our site" :
        $"Hello, {fullName}. Thank you for your subcription. We will send email to the address '{eMail}'. ";
    }
}