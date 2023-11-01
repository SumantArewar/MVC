using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using dotnetapp.Models;

namespace dotnetapp.Controllers;

public class ZooController : Controller
{
    private readonly MyDbContext context;

    public ZooController(MyDbContext _context)
    {
        context = _context;
    }
    public IActionResult List()
    {
        List<Zoo> data = null;
        try
        {
            data = context.Zoos.ToList();
            return View();
        }
        catch(System.Exception ex)
        {
            ViewBag.ErrorMessage = "0 recods present";
            return View("Error");
        }
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Zoo Zoo)
    {
        if(ModelState.IsValid)
        {
            context.Zoos.Add(Zoo);
            context.SaveChanges();
            return RedirectToAction("List");
        }
        return View();
    }
}
