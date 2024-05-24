using TerraAquire.Contracts;
using TerraAquire.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TerraAquire.Contracts.TrippingCustomers;

namespace TerraAquire.Web.Pages.Manage.TrippingCustomers
{
    public class Index : PageModel
    {
        private readonly ILogger<Index> _logger;
        private readonly ITrippingCustomerService _trippingCustomer;

        [BindProperty]
        public ViewModel Data { get; set; }
        public Index(ILogger<Index> logger, ITrippingCustomerService trippingCustomer)
        {
            _logger = logger;
            _trippingCustomer = trippingCustomer;

            Data = Data ?? new ViewModel();
        }

        public async Task OnGet(bool? IsActive = true, int? pageIndex = 1,  int? pageSize = 10 , string? keyword = "")
        {
            Data.Entity = await _trippingCustomer.Search(IsActive, pageIndex, pageSize, keyword);
        }

        public class ViewModel
        {
            public Paged<TrippingCustomerDto>? Entity { get; set; }
            public string? Items { get; set; }
        }
    }

}
