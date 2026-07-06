using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebSite.Models;
using WebSite.ViewModels;

namespace WebSite.Controllers;

public class propertiesController : Controller
{
    private readonly RealEstateDbContext _context;

    public propertiesController(RealEstateDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        const int pageSize = 9;
        var page = HttpContext.Request.Query.TryGetValue("page", out var pageValues) && int.TryParse(pageValues.FirstOrDefault(), out var parsedPage)
            ? parsedPage
            : 1;
        page = Math.Max(page, 1);

        var viewModel = new propertiesViewModel();
        viewModel.TotalCount = await _context.Properties.CountAsync();
        viewModel.CurrentPage = page;
        viewModel.PageSize = pageSize;
        viewModel.properties = await _context.Properties
            .Include(x => x.AdvertisementRelations)
                .ThenInclude(r => r.Advertisement)
            .Include(x => x.PropertyImageRelations)
                .ThenInclude(r => r.PropertyImage)
            .Include(x => x.FloorRelations)
                .ThenInclude(r => r.Floor)
            .Include(x => x.DealRelations)
                .ThenInclude(r => r.Deal)
            .Include(x => x.LocationRelations)
                .ThenInclude(r => r.Location)
                    .ThenInclude(l => l.CityRelations)
                        .ThenInclude(cr => cr.City)
            .OrderByDescending(x => x.Id)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
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
