using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using finalcal.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace finalcal.Controllers
{
    public class EmlakController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EmlakEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EmlakEkle(Emlak eml)
        {
            if(eml != null)
            {
                using (var ctx = new EmlakDbContext())
                {
                    ctx.Emlaklar.Add(eml);
                    ctx.SaveChanges();
                }
            }
            return View();
        }


       
        public IActionResult EmlakListe()
        {
            List<Emlak> lst = null;
            using (var ctx = new EmlakDbContext())
            {
                lst = ctx.Emlaklar.ToList();
            }

                return View(lst);
        }

        public IActionResult EmlakSil(int? id)
        {
            using (var ctx = new EmlakDbContext())
            {
                var eml = ctx.Emlaklar.Find(id);
                ctx.Remove(eml);
                ctx.SaveChanges();
            }


            return RedirectToAction("emlakliste");
        }

        public IActionResult EmlakDuzenle(int? id)
        {
            Emlak eml = null;
            using (var ctx = new EmlakDbContext())
            {
                eml = ctx.Emlaklar.Find(id);
            }

            return View(eml);
        }

        [HttpPost]
        public IActionResult EmlakDuzenle(Emlak eml)
        {
            using(var ctx = new EmlakDbContext())
            {
                ctx.Entry(eml).State = EntityState.Modified;
                ctx.SaveChanges();
            }

            return RedirectToAction("EmlakListe");
        }


    }
}
