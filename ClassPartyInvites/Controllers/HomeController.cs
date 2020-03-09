using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ClassPartyInvites.Models;

namespace ClassPartyInvites.Controllers
{
    public class HomeController : Controller
    {
       // private readonly ILogger<HomeController> _logger;

        public HomeController()
        {
            //_logger = logger;
        }


        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView");
        }
       

        [HttpGet]
        public ViewResult RSVPForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RSVPForm(GuestResponse guest)
        {
            if (ModelState.IsValid)
            {
             Repository.AddResponse(guest);
             return View("Thanks", guest);
            }
            else
            {
                return View();
            }
           
        }

        public ViewResult ListResponses()
        {
            return View(model: Repository.Responses.Where(r => r.WillAttend == true));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
