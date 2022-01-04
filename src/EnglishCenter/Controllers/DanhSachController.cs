using Domain.Entities;
using Domain.Interfaces;
using EnglishCenter.Models;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishCenter.Controllers
{
    public class DanhSachController : Controller
    {
        private readonly IKhoaThiRepository khoaThiRepository;
        private readonly IPhongThiRepository phongThiRepository;
        private readonly IThamGiaDuThiRepository thamGiaDuThiRepository;
        private readonly ISoBaoDanhRepository soBaoDanhRepository;

        public DanhSachController(IKhoaThiRepository khoaThiRepository,IPhongThiRepository phongThiRepository,
            IThamGiaDuThiRepository thamGiaDuThiRepository, ISoBaoDanhRepository soBaoDanhRepository)
        {
            this.khoaThiRepository = khoaThiRepository;
            this.phongThiRepository = phongThiRepository;
            this.thamGiaDuThiRepository = thamGiaDuThiRepository;
            this.soBaoDanhRepository = soBaoDanhRepository;
        }

        public IActionResult Index()
        {
            ViewBag.KhoaThi = khoaThiRepository.GetAll();
            DanhSachViewModel vm = new DanhSachViewModel();
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(string khoaThi, string phongThi)
        {
            var listTS = thamGiaDuThiRepository.GetAll().Where(x => x.MaPhongThi.Equals(phongThi));
            List<SoBaoDanh> sbds = new();
            foreach(var item in listTS)
            {
                var sbd = soBaoDanhRepository.GetByEager(item.SBD);
                sbds.Add(sbd);
            }
            DanhSachViewModel vm = new DanhSachViewModel
            {
                SBDs = sbds
            };
            ViewBag.KhoaThi = khoaThiRepository.GetAll();
            return View(vm);
        }

        public JsonResult ReturnJsonList(string khoaThi)
        {
            var test = phongThiRepository.GetAll().Where(x => x.MaKhoaThi.Equals(khoaThi));
            //var jsonData = test;
            return Json(test);
        }
    }
}
