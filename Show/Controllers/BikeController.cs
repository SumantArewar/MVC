using System;
using Microsoft.AspNetCore.Mvc;
using Show.Models;

namespace Show.Controllers;

public class BookController : Controller
{
    private readonly MTDbContext context;

    public BookController(MTDbContext _context)
    {
        context = _context;
    }
}