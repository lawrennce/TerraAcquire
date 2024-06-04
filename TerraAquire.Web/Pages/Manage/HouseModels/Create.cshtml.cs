using TerraAquire.Contracts;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TerraAquire.Web.Pages.Manage.Users
{
    public class Create : PageModel
    {
        private readonly ILogger<Create> _logger;
        private readonly IUserService _userService;
        [BindProperty]
        public ViewModel Data { get; set; }
        public Create(ILogger<Create> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;

            Data = Data ?? new ViewModel();
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid != true)
                return Page();

            return RedirectPermanent("~/manage/entity/index");
        }

        public class ViewModel
        {
            public string? Entity { get; set; }

        }
    }
}