using System;
using System.Collections.Generic;

namespace MarinaIvanna
{
    public partial class Problems
    {
        public Problems()
        {
            UserRequiesties = new HashSet<UserRequiesties>();
        }

        public long Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }

        

        public virtual ICollection<UserRequiesties> UserRequiesties { get; set; }
    }
}
