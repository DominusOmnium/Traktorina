using System;
using System.Collections.Generic;

namespace MarinaIvanna
{
    public partial class UserRoles
    {
        public UserRoles()
        {
            Users = new HashSet<Users>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
