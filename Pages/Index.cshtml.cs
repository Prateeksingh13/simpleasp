using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SimpleWebApp.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        public string Message { get; private set; }

        public void OnGet()
        {
            // Executed when the page is initially requested.
        }

        public void OnPost()
        {
            if (!string.IsNullOrEmpty(Name))
            {
                Message = $"Hello, {Name}! Welcome to ASP.NET Core.";
            }
            else
            {
                Message = "Please enter your name.";
            }
        }
    }
}
