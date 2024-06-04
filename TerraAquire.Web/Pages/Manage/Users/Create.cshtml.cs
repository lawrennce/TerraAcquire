using TerraAquire.Contracts;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TerraAquire.Data;

namespace TerraAquire.Web.Pages.Manage.Users.Create
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

        public IActionResult OnPost()
        {
            if (ModelState.IsValid != true)
                return Page();

            return RedirectPermanent("~/manage/users/index");
        }

        public class ViewModel
        {
            public Guid? Id { get; set; }
            public Role? Role { get; set; }
            public string? EmailAddress { get; set; }
            public string? Password { get; set; }
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
            public string? ProfileImage { get; set; }
            public string? FullName
            {
                get
                {
                    return this.FirstName + " " + this.LastName;
                }
            }

        }
    }
}