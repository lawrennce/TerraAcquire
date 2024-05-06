using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace TerraAquire.Data
{
    public class User
    {
        public Guid? Id { get; set; }
        public Role? Role{ get; set; }
        public string? EmailAddress { get; set; }
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
        public string? ProfileImage { get; set; }
    }
}
