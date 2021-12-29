using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearnRazorPages.Pages{
    public class Practice03Model :PageModel{
        public string Message {get;set;}
        public void OnGet(){

        }
        public void OnPost(){

        }

        public void OnPostDelete(){
            Message = "Delete Handler fired";
        }
        public void OnPostEdit(){
            Message = "Edit Handler fired";
        }
        public void OnPostAdd(){
            Message = "Add Handler fired";
        }
    }
}