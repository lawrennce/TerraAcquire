using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraAquire.Data 
{
    public class TrippingCustomer
    {
        public Guid? TrippingId { get; set; }
        public Guid? CustomerId { get; set; }
        public User? Customer { get; set; }
        public bool? IsActive { get; set; }
        public Guid? Id { get; set; }
    }
}
