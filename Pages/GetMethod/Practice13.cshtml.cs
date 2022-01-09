using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearnRazorPages.Pages{
    public class Practice13Model:PageModel{
        [ViewData]
        public string Title {get;set;}
        public string Text {get;set;}
        public void OnGet(string title){ //title được lấy từ url, được cấu hình bởi @page "{title}"
            //var title = RouteData.Values["title"].ToString();
            Title = title.Replace('-',' ')
                        .ToUpper();
            Text = "Test route data";
        }
    }
}