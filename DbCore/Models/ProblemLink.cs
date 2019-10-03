using System;
using System.Collections.Generic;
using System.Text;
using LibCore;
using MarinaIvanna;

namespace DbCore.Models
{
    public class ProblemLink : IPrimaryKeyContainer
    {
        public long Id { get; set; }

        public long? UserId { get; set; }
        public virtual Users User { get; set; }
        public virtual Companies Company { get; set; }
        public virtual Problems Problem { get; set; }
    }
}
