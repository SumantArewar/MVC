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
    public class DetailController : ControllerBase
    {
        MovieContext context = new MovieContext();

        [HttpGet]
        [Route("DisplayDetails/{id}")]
        public IActionResult Get(int id)
        {
            var data = from d in context.Details select d;
            return Ok(data);
        }

        [HttpGet]
        [Route("ListDetails")]
        public IActionResult Get()
        {
            var data = from d in context.Details select new {MovieName = d.Movie.Name, Artist = d.Actor};
            return Ok(data);
        }
        [HttpGet]
        [Route("ListDetails/{id}")]
        public IActionResult Get(int ?id)
        {
            if (id==null)
            {
                return BadRequest("Id cannot be null");
            }
            var data = (from m in context.Details where m.DetailId == id select m).FirstOrDefault();

            if (data==null)
            {
                return NotFound($"Movie {id} cannot be null");
            }
            return Ok(data);            
        }
        [HttpPost]
        [Route("AddDetails")]
        public IActionResult Post(Detail detail)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    context.Details.Add(detail);
                    context.SaveChanges();
                }
                catch(System.Exception ex)
                {
                    return BadRequest(ex.InnerException.Message);
                }
            }
            return Created("Record Added",detail);
        }


        [HttpDelete]
        [Route("DeleteDetails/{id}")]
        public IActionResult Delete(int id)
        {
            var data = context.Details.Find(id);
            context.Details.Remove(data);
            context.SaveChanges();
            return Ok();
        }



        // private readonly ILogger<DetailController> _logger;

        // public DetailController(ILogger<DetailController> logger)
        // {
        //     _logger = logger;
        // }

        // public IActionResult Index()
        // {
        //     return View();
        // }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");
        // }
    }
}