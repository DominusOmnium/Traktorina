using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Internal;

namespace MarinaIvanna.Tools
{
    public static class AuthChecker
    {
        public static bool Check(trbdContext context, string login, string password)
        {

            var user = context.Users.FirstOrDefault(x => x.Login == login);
            if (user == null)
                return false;
            var salt = user.Salt;
            var passBytes = Encoding.UTF8.GetBytes(password);
            var ts = SHA256.Create();
            var candidate = ts.ComputeHash(salt.Concat(passBytes).ToArray());
            var result = candidate.SequenceEqual(user.Hash);
            if (result)
                user.LastLogin = DateTime.Now;

            context.SaveChanges();

            return result;
        }
    }
}
