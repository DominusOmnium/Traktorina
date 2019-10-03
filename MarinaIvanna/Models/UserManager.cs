using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarinaIvanna.Models
{
    public class UserManager
    {
        public UserManager()
        {

        }

        public UserManager(Users user, IEnumerable<Problems> problems, IEnumerable<UserRequiesties> userRequiesties )
        {
            UserName = user.Name;
            UserMail = user.Login;
            Problems = problems;
            UserRequests = userRequiesties.Select(x =>
                    new UserRequest((int) x.Id, x.Message, x.Email, x.Name, x.Address, x.Company.Name, x.Status.StatusName))
                .ToList();
        }
       public string UserName { get; set; }
       public string UserMail { get; set; }
       public IEnumerable<Problems> Problems { get; set; }
       public IEnumerable<UserRequest> UserRequests { get; set; }
    }
}
