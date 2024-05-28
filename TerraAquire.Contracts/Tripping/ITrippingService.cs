using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraAquire.Contracts.HouseModels;

namespace TerraAquire.Contracts.Trippings
{
    public interface ITrippingService : IService
    {
        Task<Paged<TrippingDto>>? Search(bool? isActive = true, int? pageIndex = 1, int? pageSize = 10, string? keyword = "");
    }
}

