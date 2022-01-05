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
        private readonly IThiSinhRepository thiSinhRepository;
        private readonly ISoBaoDanhRepository soBaoDanhRepository;
        private readonly IThamGiaDuThiRepository thamGiaDuThiRepository;
        private readonly IPhongThiRepository phongThiRepository;

        public ThongKeController(IThiSinhRepository thiSinhRepository, ISoBaoDanhRepository soBaoDanhRepository,
            IThamGiaDuThiRepository thamGiaDuThiRepository,IPhongThiRepository phongThiRepository)
        {
            this.thiSinhRepository = thiSinhRepository;
            this.soBaoDanhRepository = soBaoDanhRepository;
            this.thamGiaDuThiRepository = thamGiaDuThiRepository;
            this.phongThiRepository = phongThiRepository;
        }

        public IActionResult Index()
        {
            ViewBag.TSA2 = thamGiaDuThiRepository.GetAll().Where(x => x.MaPhongThi.StartsWith("A2")).Count();
            ViewBag.TSB1 = thamGiaDuThiRepository.GetAll().Where(x => x.MaPhongThi.StartsWith("B1")).Count();
            ViewBag.PTA2 = phongThiRepository.GetAll().Where(x => x.MaPhongThi.StartsWith("A2")).Count();
            ViewBag.PTB1 = phongThiRepository.GetAll().Where(x => x.MaPhongThi.StartsWith("B1")).Count();
            
            return View();
        }

        [HttpPost]
        public IActionResult Index(string sdt, string hoTen)
        {
            if (sdt != null || hoTen != null)
            {
                var ts = thiSinhRepository.Find(sdt,hoTen);
                if(ts == null)
                {
                    ViewBag.Message = "Không tồn tại !";
                    return RedirectToAction("Index");
                }
                var sbd = soBaoDanhRepository.Find(ts.CMND);
                var diem = thamGiaDuThiRepository.GetAll().Where(x => x.SBD == sbd.SBD).FirstOrDefault();
                ThongTinViewModel viewModel = new ThongTinViewModel()
                {
                    ThiSinh = ts,
                    SoBaoDanh = sbd,
                    ThamGiaDuThi = diem
                };

                return View("ThongTin",viewModel);
            }
            return RedirectToAction("Index");
        }
    }
}
