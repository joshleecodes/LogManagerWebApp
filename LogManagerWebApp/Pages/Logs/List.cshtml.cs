using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LogManager.Core;
using LogManager.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LogManagerWebApp.Pages.Logs
{
    public class ListModel : PageModel
    {
        private readonly ILogData _logData;

        [BindProperty(SupportsGet =true)]
        public string SearchTerm { get; set; }
        public IEnumerable<Log> Logs { get; set; }

        public ListModel(ILogData logdata)
        {
            _logData = logdata;
        }

        public void OnGet()
        {
            Logs = _logData.GetLogCalled(SearchTerm);
        }
    }
}