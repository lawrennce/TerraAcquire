using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraAquire.Contracts.TrippingCustomers;

namespace TerraAquire.Contracts.TrippingCustomers
{
    public interface ITrippingCustomerService : IService
    {
        Task<Paged<TrippingCustomerDto>>? Search(bool? isActive = true, int? pageIndex = 1, int? pageSize = 10, string? keyword = "");
    }
}
