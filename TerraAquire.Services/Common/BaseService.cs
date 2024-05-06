using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Security.Claims;


namespace TerraAquire.Services.Common
{

    public abstract class BaseService
    {
        protected readonly IMapper Mapper;
        protected readonly IConfiguration Configuration;
        protected readonly ILogger<BaseService> Logger;

        public BaseService(IConfiguration configuration, ILogger<BaseService> logger, IMapper mapper)
        {
            Configuration = configuration;
            Logger = logger;
            Mapper = mapper;
        }
    }
}
