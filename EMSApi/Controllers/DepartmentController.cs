using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace EMSApi.Controllers
{
    [Route("[controller]")]
    public class DepartmentController : Controller
    {
        [ApiController]
        [Route("[controller]")]
        public class DepartmentController : ControllerBase
        {
            IDecrementOperators repo;
            public DepartmentController(IDecrementOperators _repo)
            {
                this.repo = _repo;
            }
            [HttpGet]
            [Route("ListDept")]
            public IActionResult GetDept()
            {
                var data = repo.GetDepartments();
                return Ok(data);
            }
            [HttpPost]
            [Route("Create")]
            public IActionResult PostDept(Department department)
            {
                if(ModelState.IsValid)
                {
                    repo.AddDept(department);
                    return Created("Record Added",department);
                }
                return BadRequest();
            }
        } 
    }
}