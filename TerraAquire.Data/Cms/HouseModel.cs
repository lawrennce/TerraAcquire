using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraAquire.Data
{
    public class HouseModel
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public string? Features { get; set; }
        public string? Content { get; set; }
        public string? ARmodel { get; set; }
        public bool? IsActive { get; set; }
    }
}
