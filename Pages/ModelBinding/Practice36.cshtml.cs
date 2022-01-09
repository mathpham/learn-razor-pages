using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using LearnRazorPages.Models;

namespace LearnRazorPages.Pages.ModelBinding{
    public class Practice36Model : PageModel{
        public string Message {get;private set;}
        private string ResponseMessage(Subscription subscription) => Message = subscription.Age <18?
        $"Sorry, {subscription.FullName}. You cannot subscribe for our site.":
        $"Hello, {subscription.FullName}. Thank you for your subscription. We will send email to address '{subscription.Email}'.";
        [BindProperty]
        public Subscription Subscription {get;set;}
        public void OnPost() => Message = ResponseMessage(Subscription); //Property
        // public void OnPost(Subscription subscription) => Message = ResponseMessage(subscription); // Parameter
    }
}