using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace TerraAquire.EntityFramework
{
    public class DefaultDbContext : DbContext
    {
        public DefaultDbContext(DbContextOptions options)
            : base(options)
        {
        }
    }
}