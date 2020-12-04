using System;
using System.Collections.Generic;

namespace CIS_420_Project.Models
{
    public partial class UserType
    {
        public UserType()
        {
            Users = new HashSet<Users>();
        }

        public string UserTypeId { get; set; }
        public string UserTypeDesc { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
