using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.WebSockets;

namespace TerraAquire.Web.Pages
{
    public class Index : PageModel
    {
        private readonly ILogger<Index> _logger;

        public void OnGet()
        {

        }

        public class ViewModel
        {
        }

    }
}