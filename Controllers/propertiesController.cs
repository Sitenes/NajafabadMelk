using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebSite.Models;

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
        viewModel.staticDatas = await _context.staticDatas.Include(x => x.Group).ToListAsync();
        viewModel.TotalCount = await _context.Advertisements.CountAsync();
        viewModel.CurrentPage = page;
        viewModel.PageSize = pageSize;
        viewModel.advertisements = await _context.Advertisements
            .Include(x => x.House)
            .ThenInclude(x => x.Images)
            .Include(x => x.House)
            .ThenInclude(x => x.Floors)
            .Include(x => x.Deal)
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
