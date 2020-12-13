using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using viewModelFun.Models;

namespace viewModelFun.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/users")]
        public IActionResult Names()
        {
            User sally = new User()
            {
                FirstName = "Sally",
                LastName = "Sue"
            };
            User billy = new User()
            {
                FirstName = "Billy",
                LastName = "Boy"
            };
            User joey = new User()
            {
                FirstName = "Joey",
                LastName = "Jonah"
            };
            User moose = new User()
            {
                FirstName = "Moose",
                LastName = "Smith"
            };
            List<User> users = new List<User>()
            {
                sally, billy, joey, moose
            };
            return View(users);
        }

        [HttpGet("")]
        public IActionResult Message()
        {
            Message message = new Message()
            {
                Words = "Hello, if you are reading this then you are reading a message."
            };
            return View(message);
        }

        [HttpGet("/user")]
        public IActionResult User()
        {
            User nathan = new User()
            {
                FirstName = "Nathan",
                LastName = "Bell",
            };
            return View(nathan);
        }

        [HttpGet("/numbers")]
        public IActionResult Number()
        {
            Numbers one = new Numbers()
            {
                Value = 1
            };
            Numbers two = new Numbers()
            {
                Value = 2
            };
            int[] arr = {one.Value,two.Value};
            return View(arr);
        }

        public IActionResult Index()
        {
            return View();
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
