using System;
using System.Collections.Generic;

namespace MarinaIvanna
{
    public partial class Companies
    {
        public Companies()
        {
            UserRequiesties = new HashSet<UserRequiesties>();
            Users = new HashSet<Users>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<UserRequiesties> UserRequiesties { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
