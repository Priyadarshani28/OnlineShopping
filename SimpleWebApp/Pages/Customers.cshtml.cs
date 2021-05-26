using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SimpleWebApp.Pages
{
    public class CustomersModel : PageModel
    {
        private readonly ILogger<CustomersModel> _logger;

        public CustomersModel(ILogger<CustomersModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}