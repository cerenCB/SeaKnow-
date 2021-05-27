using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SEAKNOW.Models;

namespace SEAKNOW.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            

            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Aı()
        {
            return View();
        }

        public IActionResult MachineLearning()
        {
            return View();
        }
        [HttpGet]

        public IActionResult EmailService()
        {
            return View();
        }

        [HttpPost]

        public ActionResult EmailService(String email , String firmname)
        {
            bool emailRegex = TestEmailRegex(email);

            bool containEmail;

            if (firmname==null )
            {
                containEmail = true;

            }
            else
            {
                 containEmail = email.Contains(firmname);
            }
            if (emailRegex && containEmail)
            {
                ViewData["emailValidation"] = "E-mail format is correct";
            }
            else
            {
                ViewData["emailValidation"] = "E-mail format is not correct";

            }



            return View();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

        }

        public bool TestEmailRegex(string emailAddress)
        {
            if (emailAddress == null) return false;
            string patternStrict = @"^(([^<>()[\]\\.,;:\s@\""]+"
            + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
            + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}"
            + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
            + @"[a-zA-Z]{2,}))$";
            Regex reStrict = new Regex(patternStrict);
            bool isStrictMatch = reStrict.IsMatch(emailAddress);
            return isStrictMatch;

        }

       

    }
}
