using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SimpleWebApp.Pages
{
    public class aboutusModel : PageModel
    {
        private readonly ILogger<aboutusModel> _logger;

        public aboutusModel(ILogger<aboutusModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}