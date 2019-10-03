using System;
using System.Collections.Generic;

namespace MarinaIvanna
{
    public partial class Users
    {
        public Users()
        {
            UserRequiestiesRunner = new HashSet<UserRequiesties>();
            UserRequiestiesSender = new HashSet<UserRequiesties>();
        }

        public long Id { get; set; }
        public string Login { get; set; }
        public byte[] Hash { get; set; }
        public byte[] Salt { get; set; }
        public DateTime LastLogin { get; set; }
        public long? CompanyId { get; set; }
        public long? UserRoleId { get; set; }

        public string Name { get; set; }

        public virtual Companies Company { get; set; }
        public virtual UserRoles UserRole { get; set; }
        public virtual ICollection<UserRequiesties> UserRequiestiesRunner { get; set; }
        public virtual ICollection<UserRequiesties> UserRequiestiesSender { get; set; }
    }
}
