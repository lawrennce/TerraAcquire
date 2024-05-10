using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraAquire.Contracts.HouseModels
{
    public interface IHouseModelService : IService
    {
        Task<Paged<HouseModelDto>>? Search(bool? isActive = true, int? pageIndex = 1, int? pageSize = 10, string? keyword = "");
    }
}
