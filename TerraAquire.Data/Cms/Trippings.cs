using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraAquire.Data
{
    public class Tripping
    {
        public Guid? Id { get; set; }
        public Guid? AgentId { get; set; }
        public DateTime? DateTime { get; set; }
    }
}
