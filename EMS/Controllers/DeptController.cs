using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EMS.Models;
using System.Data;
using System.Data.SqlClient;

namespace EMS.Controllers;

public class DeptController : Controller
{
    private readonly EmsDbContext context;
    public DeptController(EmsDbContext _context)
    {
        context = _context;
    }

    // public IActionResult List()
    // {
    //     List<Department> data=null;
    //     try{

    //         data = context.Departments.ToList();
    //         if(data.Count==0)
    //         throw new Exception();
    //     }
    //     catch(System.Exception ex)
    //     {
    //         ViewBag.ErrorMessage = "0 records present";
    //         return View("Error");
    //     }
    //     return View(data);
    // }

    public IActionResult List()
    {
        List<Department> data = null;
        try
        {
            data = context.Departments.ToList();
            if(data.Count==0)
            throw new Exception();
        }
        catch(System.Exception ex)
        {
            ViewBag.ErrorMessage = "0 records present";
            return View("Error");
        }
        return View(data);
    }

    // public IActionResult List()
    // {
    //     var data = context.Departments.ToList();
    //     return View(data);
    // }

    public IActionResult Display(int id)
    {
        var data = context.Employees.Where(e=>e.DeptId==id);
        return View(data);
    }
    // public IActionResult Create()
    // {
    //     return View();
    // }
    // [HttpPost]
    // public IActionResult Create(Department department)
    // {
    //     if(ModelState.IsValid)
    //     {
    //         context.Departments.Add(department);
    //         context.SaveChanges();
    //         return RedirectToAction("List");
    //     }
    //     return View();
    // }

    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Department d)
    {
        if(ModelState.IsValid)
        {
            Department department = context.Departments.Find(d.Id);
            context.Departments.Add();
            context.SaveChanges();
            return RedirectToAction("Orders");
        }
    }
    public IActionResult Edit(int id)
    {
        var data = context.Departments.Find(id);
        return View(data);
    }
    [HttpPost]
    public IActionResult Edit(Department department)
    {
        if(ModelState.IsValid)
        {
            Department dept = context.Departments.Find(department.Id);
            dept.DeptName = department.DeptName;
            dept.Location = department.Location;
            
            context.SaveChanges();
            return RedirectToAction("List");
        }
        return View();
    }

    public IActionResult Delete(int id)
    {
        var data = context.Departments.Find(id);
        return View(data);
    }
    [HttpPost]
    public IActionResult Delete(Department d)
    {
        Department department = context.Departments.Find(d.Id);
        context.Departments.Remove(department);
        context.SaveChanges();
        return RedirectToAction("List");
    }
}
