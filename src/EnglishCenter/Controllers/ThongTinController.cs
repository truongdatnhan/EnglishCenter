using Domain.Interfaces;
using EnglishCenter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishCenter.Controllers
{
    public class ThongTinController : Controller
    {
        private readonly IThiSinhRepository thiSinhRepository;

        public ThongTinController(IThiSinhRepository thiSinhRepository)
        {
            this.thiSinhRepository = thiSinhRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(DangKyViewModel vm)
        {
            if (ModelState.IsValid)
            {
                thiSinhRepository.Add(vm.ThiSinh);
                ViewBag.Message = "Đăng ký thành công !";
                return View();
            }
            return RedirectToAction("Index");
        }
    }
}
