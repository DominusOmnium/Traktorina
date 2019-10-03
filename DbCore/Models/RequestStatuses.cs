using System;
using System.Collections.Generic;

namespace MarinaIvanna
{
    public partial class RequestStatuses
    {
        public RequestStatuses()
        {
            UserRequiesties = new HashSet<UserRequiesties>();
        }

        public long Id { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<UserRequiesties> UserRequiesties { get; set; }
    }
}
