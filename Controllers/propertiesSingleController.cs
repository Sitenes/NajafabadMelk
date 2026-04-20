using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebSite.Models;

namespace WebSite.Controllers;

public class propertiesSingleController : Controller
{
    private readonly RealEstateDbContext _context;

    public propertiesSingleController(RealEstateDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index(int id)
    {
        if (id <= 0)
        {
            return RedirectToAction("Index", "properties");
        }

        var viewModel = new propertiesSingleViewModel();
        viewModel.staticDatas = await _context.staticDatas.Include(x => x.Group).ToListAsync();

        viewModel.advertisement = await _context.Advertisements
            .Include(x => x.House)
            .ThenInclude(x => x.Images)
            .Include(x => x.House)
            .ThenInclude(x => x.Floors)
            .ThenInclude(x => x.ToiletType)
            .Include(x => x.Deal)
            .ThenInclude(x => x.DealType)
            .FirstOrDefaultAsync(x => x.Id == id);

        if (viewModel.advertisement is null)
        {
            return NotFound();
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
