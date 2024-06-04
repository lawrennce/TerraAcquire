using TerraAquire.Contracts;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TerraAquire.Contracts.TrippingCustomers;

namespace TerraAquire.Web.Pages.Manage.TrippingCustomers
{
    public class Create : PageModel
    {
        private readonly ILogger<Create> _logger;
        private readonly ITrippingCustomerService _trippingcustomerService;
        [BindProperty]
        public ViewModel Data { get; set; }
        public Create(ILogger<Create> logger, ITrippingCustomerService trippingcustomerService)
        {
            _logger = logger;
            _trippingcustomerService = trippingcustomerService;

            Data = Data ?? new ViewModel();
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid != true)
                return Page();

            return RedirectPermanent("~/manage/trippingcustomer/index");
        }

        public class ViewModel
        {
            public string? Entity { get; set; }

        }
    }
}