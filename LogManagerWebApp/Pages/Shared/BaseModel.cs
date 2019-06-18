using LogManager.Core;
using LogManager.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogManagerWebApp.Pages.Shared
{
    public class BaseModel : PageModel
    {
        public readonly ILogData _logData;
        public readonly ISystemUtility _systemUtility;

        public string Title { get; set; }
        public IEnumerable<Log> Logs { get; set; }

        [BindProperty(SupportsGet = true)]
        public string CurrentDirectory { get; set; }

        [BindProperty(SupportsGet = true)]
        public string RequestedDirectory { get; set; }

        public BaseModel(ILogData logData, ISystemUtility systemUtility)
        {
            _logData = logData;
            _systemUtility = systemUtility;
        }

        public void UpdateDirectory()
        {
            if (_systemUtility.IsValidDirectory(RequestedDirectory))
            {
                CurrentDirectory = RequestedDirectory;
            }
            else if (string.IsNullOrEmpty(CurrentDirectory))
            {
                CurrentDirectory = "Please enter a directory";
            }
            else
            {
                RequestedDirectory = CurrentDirectory;
            }
        }

        public void DisplayDirectoryFeedback()
        {

        }
    }
}
