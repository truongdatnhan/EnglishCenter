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
    public class ThongKeController : Controller
    {
        private readonly IKhoaThiRepository khoaThiRepository;
        private readonly IThamGiaDuThiRepository thamGiaDuThiRepository;
        private readonly IPhongThiRepository phongThiRepository;

        public ThongKeController(IKhoaThiRepository khoaThiRepository,
            IThamGiaDuThiRepository thamGiaDuThiRepository,IPhongThiRepository phongThiRepository)
        {
            this.khoaThiRepository = khoaThiRepository;
            this.thamGiaDuThiRepository = thamGiaDuThiRepository;
            this.phongThiRepository = phongThiRepository;
        }

        public IActionResult Index()
        {
            ViewBag.TSA2 = thamGiaDuThiRepository.GetAll().Where(x => x.MaPhongThi.StartsWith("A2")).Count();
            ViewBag.TSB1 = thamGiaDuThiRepository.GetAll().Where(x => x.MaPhongThi.StartsWith("B1")).Count();
            ViewBag.PTA2 = phongThiRepository.GetAll().Where(x => x.MaPhongThi.StartsWith("A2")).Count();
            ViewBag.PTB1 = phongThiRepository.GetAll().Where(x => x.MaPhongThi.StartsWith("B1")).Count();
            var khoaThi = khoaThiRepository.GetAll().Select(x =>x.MaKhoaThi);
            var TSA2Khoa = new List<int>();
            var TSB1Khoa = new List<int>();
            foreach (var item in khoaThi)
            {
                TSA2Khoa.Add(khoaThiRepository.CountTSByKhoa(item, "A2"));
                TSB1Khoa.Add(khoaThiRepository.CountTSByKhoa(item, "B1"));
            }
            ViewBag.KhoaThi = khoaThi;
            ViewBag.TSA2Khoa = TSA2Khoa;
            ViewBag.TSB1Khoa = TSB1Khoa;
            return View();
        }
    }
}
