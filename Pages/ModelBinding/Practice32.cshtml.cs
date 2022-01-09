using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;


namespace LearnRazorPages.Pages {
    public class Practice32Model : PageModel {
        [BindProperty]
        public int Age {get;set;}
        [BindProperty]
        public string fullName {get;set;}
        [BindProperty]
        public string eMail {get;set;}
        public string Message {get; private set;}
        public void OnPost(){
            if(Age <18){
                Message = "Sorry," +fullName + ". You cannot subscribe for our site.";
            }
            else{
                Message = "Hello,"+fullName+". Thank you for your subcription. We will send email to " + eMail  + ".";
            }
        }
    }
}