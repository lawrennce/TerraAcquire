
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraAquire.Contracts;
using TerraAquire.MySql.Infrastructure;

namespace TerraAquire.MySql.Infrastructure
{
    public static class DataRepositoryExtension
    {
        public static void AddDataRepositories(this IServiceCollection services)
            => services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
    }
}
