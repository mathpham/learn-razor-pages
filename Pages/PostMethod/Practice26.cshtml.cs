using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearnRazorPages.Pages{
    public class Practice26Model : PageModel{
        public (string value, string display)[] Countries => new[]{
            ("USA","United States of Ameria"),
            ("China","People Republic of China"),
            ("Japan", "Japan"),
            ("Germany","Federal Republic of Germany")
        };
        //public string[] VisitedCountries{get; private set;}
        public List<string> VisitedCountries{get; private set;}
        public void OnPost(List<string> countries){
            //var countries = Request.Form["countries"];
            VisitedCountries = countries;
        }
    }
}