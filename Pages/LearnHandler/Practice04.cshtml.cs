using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearnRazorPages.Pages{
    public class Practice04Model : PageModel{
        public string Message{get;set;} = "Defalt GET Method";
        public void OnPostRegister() => Message = "Post Register fired";
        public void OnPostRequestInfo() => Message = "Post Request Info fired";
        public void OnGetClear() => Message = "Get Clear fired";
        public void OnGetReset() => Message = "Get Reset fired";
    }
}