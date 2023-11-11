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
            context.Tracks.Add(T);
            context.SaveChanges();
            return RedirectToAction("Index");
            return View();
        }

        public IActionResult Edit()
        {
            
            return View();
        }
    }
}