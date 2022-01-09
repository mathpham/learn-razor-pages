using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearnRazorPages.Pages{
    public class Practice31Model : PageModel{
        public string Message {get;private set;}
        public void OnPost(string fullName, string eMail, int age) => Message = age < 18 ?
        $"Sorry, {fullName}. You cannot subcribe for our site" :
        $"Hello, {fullName}. Thank you for your subcription. We will send email to the address '{eMail}'. ";
    }
}