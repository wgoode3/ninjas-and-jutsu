using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Naruto.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Naruto.Controllers
{
    public class HomeController : Controller
    {
        private MyContext scroll;
        
        public HomeController(MyContext mc)
        {
            scroll = mc;
        }
        
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.Ninjas = scroll.Ninjas;
            ViewBag.Jutsus = scroll.Jutsus;
            ViewBag.AllNinjas = scroll.Ninjas
                .Include(n => n.KnownJutsu);
            return View();
        }

        [HttpPost("ninja")]
        public IActionResult Ninja(Ninja ninja)
        {
            if(ModelState.IsValid)
            {
                scroll.Create(ninja);
                return Redirect("/");
            }
            else
            {
                ViewBag.Ninjas = scroll.Ninjas;
                ViewBag.Jutsus = scroll.Jutsus;
                ViewBag.AllNinjas = scroll.Ninjas
                    .Include(n => n.KnownJutsu);
                return View("Index");
            }
        }

        [HttpPost("jutsu")]
        public IActionResult Jutsu(Jutsu jutsu)
        {
            if(ModelState.IsValid)
            {
                scroll.Create(jutsu);
                return Redirect("/");
            }
            else
            {
                ViewBag.Ninjas = scroll.Ninjas;
                ViewBag.Jutsus = scroll.Jutsus;
                ViewBag.AllNinjas = scroll.Ninjas
                    .Include(n => n.KnownJutsu);
                return View("Index");
            }
        }

        [HttpPost("ninjutsu")]
        public IActionResult Ninjutsu(Ninjutsu ninjutsu)
        { 
            scroll.Create(ninjutsu);
            return Redirect("/");
        }

        [HttpGet("remove/{NinjaId}/{JutsuId}")]
        public IActionResult Remove(int NinjaId, int JutsuId)
        {
            scroll.Remove(NinjaId, JutsuId);
            return Redirect("/");
        }
    }
}
