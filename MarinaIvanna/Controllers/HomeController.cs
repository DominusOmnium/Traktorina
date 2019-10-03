using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MarinaIvanna.Models;
using System.Net;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MarinaIvanna.Tools;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MarinaIvanna.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

       

        public IActionResult UserMC(string userMailorUid)
        {
            var context = _configuration.Get<trbdContext>();
            var a = context.UserRequiesties
                .Where(x => x.Email == userMailorUid || x.Uid == userMailorUid);
         /*   a.Select(x => {
                var res = new UserRequest((int)x.Id, x.Message, x.Email, x.Name, x.Address, x.Company.Name,
                        x.Status?.StatusName)
                    { ManagerName = x.Runner?.Name };
                return res;
            });
                a.Select(x )
           var lst = a                .Select(x =>
                {
                    var res = new UserRequest((int) x.Id, x.Message, x.Email, x.Name, x.Address, x.Company.Name,
                        x.Status?.StatusName) {ManagerName = x.Runner?.Name};
                    return res;
                }).ToList();*/
            return View(null);
        }

        [HttpPost]
        public IActionResult AuthorizationUser(User user)
        {
            trbdContext context = _configuration.Get<trbdContext>();
            return AuthChecker.Check(context, user.Login, user.Password) ? RedirectToAction("ManagerMC", "Home", user) : RedirectToAction(nameof(AuthorizationUser), "Home");
        }

        [HttpGet]
        public IActionResult AuthorizationUser()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ManagerMC(User user)
        {
            var context = _configuration.Get<trbdContext>();
            var curUser = context.Users.FirstOrDefault(x => x.Login == user.Login);
            var requests = context.UserRequiesties.Where(x => x.RunnerId == curUser.Id);
            foreach (var userRequiestiese in requests)
            {
                userRequiestiese.Company = context.Companies.FirstOrDefault(x => x.Id == userRequiestiese.CompanyId);
                userRequiestiese.Status = context.RequestStatuses.FirstOrDefault(x => x.Id == userRequiestiese.StatusId);
            }
            var model = new UserManager(curUser, context.ProblemLinks.Where(x => x.UserId == curUser.Id).Select(x => x.Problem), requests);
            List<UserRequest> ur = new List<UserRequest>();
            ur.Add(new UserRequest(1, "regr", "thr", "reer", "eweffef", "aq", "dfs"));
            ur.Add(new UserRequest(2, "regr", "thr", "reer", "eweffef", "aq", "dfs"));
            ur.Add(new UserRequest(3, "regr", "thr", "reer", "eweffef", "aq", "dfs"));
            ur.Add(new UserRequest(4, "regr", "thr", "reer", "eweffef", "aq", "dfs"));
            ur.Add(new UserRequest(5, "regr", "thr", "reer", "eweffef", "aq", "dfs"));
            ur.Add(new UserRequest(6, "regr", "thr", "reer", "eweffef", "aq", "dfs"));
            ur.Add(new UserRequest(7, "regr", "thr", "reer", "eweffef", "aq", "dfs"));
            ur.Add(new UserRequest(8, "regr", "thr", "reer", "eweffef", "aq", "dfs"));
            ur.Add(new UserRequest(9, "regr", "thr", "reer", "eweffef", "aq", "dfs"));
            ViewBag.M_name = curUser?.Name;
            ViewBag.M_email = curUser?.Login;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRequest req)
        {

            
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://194.58.102.106:4567/echo");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(new
                {
                    text = req.Message,
                });

                streamWriter.Write(json);
            }

            if (req.Message != null && req.Message.Trim() != "")
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd().Split('\n');
                    foreach (var r in result)
                        if (r.Trim() != "")
                            req.Type += Dictionary.Translate(r) + "; ";
                    Random rand = new Random();
                    req.Id = rand.Next(0, 999);
                    req.Status = "В работе";

                    switch(req.Address)
                    {
                        case "a1":
                            req.Company = "Мясные рулетики";
                            break;
                        case "a2":
                            req.Company = "Фонарики";
                            break;
                        case "a3":
                            req.Company = "Василек";
                            break;
                    }
                }
            }

            return RedirectToAction("UserMC", "Home", req);
        }

        public IActionResult ManagerMC(int id, String email, String name)
        {
            // Запрос в базу данных
            int Id = id;
            String Em = email;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
