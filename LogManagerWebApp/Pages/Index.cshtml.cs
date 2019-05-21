using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LogManagerWebApp.Pages
{
    public class IndexModel : PageModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string HelpTitle { get; set; }
        public string HelpDescription { get; set; }

        public void OnGet()
        {
            Title = "Section Title";
            Description = "Here is a paragraph that introduces the section, its capabilities and restrictions.";
            HelpTitle = "Having Trouble?";
            HelpDescription =
                "If you're having issues please take a look at the help section. " +
                "It provides section specific information on common errors, user-mistakes and easy fixes.";
        }
    }
}
