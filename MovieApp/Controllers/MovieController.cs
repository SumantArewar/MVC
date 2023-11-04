using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class MovieController : Controller
    {
        MovieContext context = new MovieContext();
        [HttpGet]
        [Route("ListMovies")]
        public IActionResult Get()
        {
            // var datda = context.Movies.ToList();
            var data = from m in context.Movies select m;
            return Ok(data);
        }














        private readonly MovieContext _context;

        public MovieController(MovieContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");
        // }
    }
}