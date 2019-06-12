using LogManager.Core;
using LogManager.Data;
using LogManagerWebApp.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LogManagerWebApp.Pages
{
    public class IndexModel : BaseModel
    {
        public string Description { get; set; }
        public string HelpTitle { get; set; }
        public string HelpDescription { get; set; }

        public IndexModel(ILogData logData, ISystemUtility systemUtility):base(logData, systemUtility)
        {
        }

        public void OnGet()
        {
            UpdateDirectory();

            Title = "Welcome";

            Description = "Here is a paragraph that introduces the section, its capabilities and restrictions.";
            HelpTitle = "Having Trouble?";
            HelpDescription =
                "If you're having issues please take a look at the help section. " +
                "It provides section specific information on common errors, user-mistakes and easy fixes.";
        }
    }
}
