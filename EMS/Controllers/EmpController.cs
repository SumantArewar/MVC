using System.Diagnostics;
using EMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EMS.Controllers;

public class EmpController : Controller
{
    private readonly EmsDbContext context;
    public EmpController(EmsDbContext _context)
    {
        context = _context;
    }

    public IActionResult List()
    {
        var data = context.Employees.Include("Dept").ToList();
        return View(data);
    }
    public IActionResult Create()
    {
        ViewBag.DeptId = new SelectList(context.Departments,"Id","DeptName");
        return View();
    }
    [HttpPost]
    public IActionResult Create(Employee emp)
    {
        // if(ModelState.IsValid)
        
            context.Employees.Add(emp);
            context.SaveChanges();
            return RedirectToAction("List");
        
        ViewBag.DeptId = new SelectList(context.Departments,"Id","DeptName");
        return View(emp);
    }

}