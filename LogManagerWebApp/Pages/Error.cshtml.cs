using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LogManager.Core;
using LogManager.Data;
using LogManagerWebApp.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LogManagerWebApp.Pages
{
    public class ErrorModel : BaseModel
    {

        public ErrorModel(ILogData logData, ISystemUtility systemUtility) : base(logData, systemUtility)
        {

        }

        public void OnGet()
        {

        }
    }
}