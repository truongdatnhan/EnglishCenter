using Domain.Interfaces;
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
    public class ChungNhanController : Controller
    {
        private readonly ISoBaoDanhRepository soBaoDanhRepository;
        private readonly IThiSinhRepository thiSinhRepository;

        public ChungNhanController(ISoBaoDanhRepository soBaoDanhRepository, IThiSinhRepository thiSinhRepository)
        {
            this.soBaoDanhRepository = soBaoDanhRepository;
            this.thiSinhRepository = thiSinhRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ChungNhan(string sbd)
        {
            if(sbd != null)
            {
                var ts = soBaoDanhRepository.GetByEager(sbd);
                if(ts != null)
                {
                    ChungNhanViewModel vm = new ChungNhanViewModel
                    {
                        SBD = ts
                    };
                    return View(vm);
                }
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
