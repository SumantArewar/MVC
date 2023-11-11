using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;
using Racing.Models;

namespace Racing.Controllers
{
    [Route("[controller]")]
    public class TrackController : Controller
    {
        private readonly RDbContext context;
        public TrackController(RDbContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            var data = context.Tracks.ToList();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Track T)
        {
            if(ModelState.IsValid)
            {
                context.Tracks.Add(T);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int id)
        {
            var data = context.Tracks.Find(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(Track Tk)
        {
            if(ModelState.IsValid)
            {
                Track track = context.Tracks.Find(Tk.TrId);
                track.TrName = Tk.TrName;
                track.Capcity = Tk.Capcity;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            var data = context.Tracks.Find(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Delete(Track Tr)
        {
            Track track = context.Tracks.Find(Tr.TrId);
            context.Tracks.Remove(track);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        // public IActionResult DeleteConfirmed(int id)
        // {
        //     var data = context.Tracks.Find(id);
        //     context.Tracks.Remove(data);
        //     context.SaveChanges();
        //     return View(data);
        // }

    }
}