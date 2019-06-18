using LogManager.Core;
using LogManager.Data;
using LogManagerWebApp.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LogManagerWebApp.Pages
{
    public class IndexModel : BaseModel
    {

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public IndexModel(ILogData logData, ISystemUtility systemUtility):base(logData, systemUtility)
        {
        }

        public void OnGet()
        {
            UpdateDirectory();
            Title = "Log Search";
            Logs = _logData.GetLogCalled(SearchTerm);
        }
    }
}
