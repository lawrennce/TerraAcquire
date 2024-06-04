using TerraAquire.Contracts;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TerraAquire.Data;

namespace TerraAquire.Web.Pages.Manage.Trippings
{
   public class CreateDto
    {
        public Guid? Id { get; set; }
        public string? Title { get; set; }
        public Guid? UserId { get; set; }
        public string? Content { get; set; }
    }
}