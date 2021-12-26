using EnglishCenter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishCenter.Controllers
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

        public IActionResult ThongTin()
        {
            return View();
        }

        public IActionResult ChungNhan()
        {
            return View();
        }

        public IActionResult DanhSach()
        {
            return View();
        }

        public IActionResult ThongKe()
        {
            return View();
        }

        public JsonResult ReturnJsonList(int categoryId)
        {
            List<string> test = new();
            test.Add("123");
            test.Add("222");
            //var jsonData = test;
            return Json(test);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
