using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Email;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TokioMarine.Models;

namespace TokioMarine.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmailSender _emailSender;

        public HomeController(ILogger<HomeController> logger, IEmailSender emailSender)
        {
            _logger = logger;
            _emailSender = emailSender;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }  
        public IActionResult SendEmail()
        {
            var message = new Message(new string[] { "bahytalaat97@gmail.com" }, "Test email", "This is the content from our email.");
            _emailSender.SendEmail(message);
            return Content("Email was sent successfully");  
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
