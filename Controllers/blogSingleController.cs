using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebSite.Models;
using WebSite.ViewModels;

namespace WebSite.Controllers;

public class blogSingleController : Controller
{
    private readonly RealEstateDbContext _context;

    public blogSingleController(RealEstateDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index(int? id)
    {
        var viewModel = new blogSingleViewModel();
        viewModel.staticDatas = await _context.StaticDatas.Include(x => x.Group).ToListAsync();
        viewModel.article = await _context.Properties
            .Include(x => x.AdvertisementRelations)
                .ThenInclude(r => r.Advertisement)
            .Include(x => x.PropertyImageRelations)
                .ThenInclude(r => r.PropertyImage)
            .FirstOrDefaultAsync(x => x.Id == id) ?? await _context.Properties.FirstOrDefaultAsync();
        
        viewModel.recentArticles = await _context.Properties
            .Include(x => x.AdvertisementRelations)
                .ThenInclude(r => r.Advertisement)
            .Include(x => x.PropertyImageRelations)
                .ThenInclude(r => r.PropertyImage)
            .Take(4)
            .ToListAsync();

        if (viewModel.article == null)
        {
            return RedirectToAction("Index", "blog");
        }

        return View(viewModel);
    }

    public IActionResult services()
    {
        return View();
    }

    public IActionResult propertiesSingle()
    {
        return View();
    }

    public IActionResult properties()
    {
        return View();
    }

    public IActionResult contact()
    {
        return View();
    }

    public IActionResult blogSingle()
    {
        return View();
    }

    public IActionResult blog()
    {
        return View();
    }

    public IActionResult agent()
    {
        return View();
    }

    public IActionResult about()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
