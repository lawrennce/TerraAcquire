using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraAquire.Data;

namespace TerraAquire.Contracts.Trippings
{
    public class TrippingDto
    {
        public Guid? Id { get; set; }
        public Guid? AgentId { get; set; }
        public User? Agent { get; set; }
        public DateTime? DateTime { get; set; }
    }
}
