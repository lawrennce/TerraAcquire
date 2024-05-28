using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraAquire.Data;

namespace TerraAquire.Contracts.Users
{
    public class UserDto
    {
        public Guid? Id { get; set; }
        public Role? Role { get; set; }
        public string? EmailAddress { get; set; }
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ProfileImage { get; set; }
        public string? FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }
    }
}
