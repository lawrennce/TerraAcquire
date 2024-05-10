using TerraAquire.Contracts;
using TerraAquire.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TerraAquire.Contracts.HouseModels;

namespace TerraAquire.Web.Pages.Manage.HouseModels
{
    public class Index : PageModel
    {
        public readonly IHouseModelService _houseModelService;

        public Index(IHouseModelService houseModelService)
        {
            _houseModelService = houseModelService;
        }
        public async Task OnGet(bool? isActive = true, int? pageIndex = 1, int? pageSize = 10, string? keyword = "")
        {
            HouseModels = await _houseModelService.Search(isActive, pageIndex, pageSize, keyword);
        }

        public Paged<HouseModelDto>? HouseModels { get; set; }

    }

}
