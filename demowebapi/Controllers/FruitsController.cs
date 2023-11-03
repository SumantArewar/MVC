using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace demowebapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FruitsController : ControllerBase
    {
        static List<string> Fruits =new List<string>{"Apple","Mango","Oranges","Grapes","Banana"};
        [HttpGet]
        [Route("ShowFruits")]
        public IEnumerable<string> GetFruits()
        {
            return Fruits;
        }
        [HttpGet("{id}")]
        public string GetFruits(int id)
        {
            return Fruits[id];
        }
        [HttpPost]
        [Route("AddFruits")]
        public void Post([FromBody] string data)
        {
            Fruits.Add(data);
        }
        [HttpPut]
        [Route("Edit/{id}")]
        public void Put (int id,[FromBody]string data)
        {
            Fruits[id] = data;
        }
        [HttpDelete]
        [Route("Kill/{id}")]
        public void Delete(int id)
        {
            Fruits.RemoveAt(id);
        }

















        // private readonly ILogger<FruitsController> _logger;

        // public FruitsController(ILogger<FruitsController> logger)
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
        
    }
}