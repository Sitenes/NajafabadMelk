using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebSite.Models;
using WebSite.ViewModels;

namespace WebSite.Controllers;

public class blogController : Controller
{
    private readonly RealEstateDbContext _context;

    public blogController(RealEstateDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        const int pageSize = 8;
        var page = HttpContext.Request.Query.TryGetValue("page", out var pageValues) && int.TryParse(pageValues.FirstOrDefault(), out var parsedPage)
            ? parsedPage
            : 1;
        page = Math.Max(page, 1);

        var viewModel = new blogViewModel();
        viewModel.staticDatas = await _context.StaticDatas.Include(x => x.Group).ToListAsync();
        viewModel.articles = await _context.Properties
            .Include(x => x.AdvertisementRelations)
                .ThenInclude(r => r.Advertisement)
            .Include(x => x.PropertyImageRelations)
                .ThenInclude(r => r.PropertyImage)
            .OrderByDescending(x => x.CreatedAt)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
        viewModel.TotalCount = await _context.Properties.CountAsync();
        viewModel.CurrentPage = page;
        viewModel.PageSize = pageSize;
        
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
