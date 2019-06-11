using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHubStudents.Models;

namespace MyHubStudents.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Students> data = new List<Students>();
            Random rnd = new Random();
            for (int i = 1; i<8; i++)
            {
                data.Add(new Students()
                {
                    Name = "Class-" + i.ToString(),
                    Id = rnd.Next(10, 50)
                });
            }
            return View(data);
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
