using System;
using System.Collections.Generic;

namespace MarinaIvanna
{
    public partial class UserRequiesties
    {
        public long Id { get; set; }
        public long? ProblemsId { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public long? CompanyId { get; set; }
        public long? StatusId { get; set; }
        public long? SenderId { get; set; }
        public long? RunnerId { get; set; }
        public string Uid { get; set; }

        public virtual Companies Company { get; set; }
        public virtual Problems Problems { get; set; }
        public virtual Users Runner { get; set; }
        public virtual Users Sender { get; set; }
        public virtual RequestStatuses Status { get; set; }
    }
}
