using Microsoft.AspNetCore.Mvc;
using PordMvc.Models;

namespace PordMvc.Controllers;
/*
public class ProductController : Controller
{
    private readonly SDbContext context;
    public ProductController(SDbContext _context)
    {
        context = _context;
    }
    public IActionResult List()
    {
        var data = context.Product.ToList();
        return View(data);
    }
    public IActionResult Display(int id)
    {
        var data = context.Product.Find(id);
        return View(data);
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Product prod)
    {
        if(ModelState.IsValid)
        {
            context.Product.Add(prod);
            context.SaveChanges();
            return RedirectToAction("List");
        }
        return View();
    }
    public IActionResult Edit(int id)
    {
            var data = context.Product.Find(id);
            return View(data);
    }
    [HttpPost]
    public IActionResult Edit(Product prod)
    {
        if(ModelState.IsValid)
        {
            Product product = context.Product.Find(prod.Id);
            product.Name = prod.Name;
            product.Price = prod.Price;
            product.Stock = prod.Stock;
            context.SaveChanges();
            return RedirectToAction("List");
        }
        return View();
    }
    public IActionResult Delete(int id)
    {
            var data = context.Product.Find(id);
            return View(data);
    }
    [HttpPost]
    public IActionResult Delete(Product prod)
    {
        Product product = context.Product.Find(prod.Id);
        context.Product.Remove(product);
        context.SaveChanges();
        return RedirectToAction("List");
    }
}
*/

public class ProductController : Controller
{
    private readonly SDbContext context;
    public ProductController(SDbContext _context)
    {
        context = _context;
    }
    public IActionResult List()
    {
        var data = context.Product.ToList();
        return View(data);
    } 
    public IActionResult Display(int id)
    {
        var data = context.Product.Find(id);
        return View(data);
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Product p)
    {
        if(ModelState.IsValid)
        Product product = context.Product.Find(p.Id);
        context.Product.Add(product);
        product.Name = p.Name;
        product.Price = p.Price;
        product.Stock = p.Stock;
        context.SaveChanges();
        return RedirectToAction("List");
    }
    public IActionResult Edit(int id)
    {
        var data = context.Product.Find(id);
        return View(data);
    }
    [HttpPost]
    public IActionResult Edit(Product p)
    {
        if(ModelState.IsValid)
        {
            Product product = context.Product.Find(p.Id);

            context.SaveChanges();
            return RedirectToAction("List");
        }
        return View();
    }
    public IActionResult Delete(int id)
    {
        var data = context.Product.Find(id);
        return View(data);
    }
    [HttpPost]
    public IActionResult Delete(Product p)
    {
        if(ModelState.IsValid)
        {
            Product product = context.Product.Find(p.Id);
            context.Product.Remove(product);
            context.SaveChanges();
            return RedirectToAction("List");
        }
    }


}