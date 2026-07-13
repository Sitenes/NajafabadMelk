using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebSite.Models;
using WebSite.ViewModels;

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
        viewModel.staticDatas = await _context.StaticDatas.Include(x => x.Group).ToListAsync();

        viewModel.property = await _context.Property
            .Include(x => x.AdvertisementRelations)
                .ThenInclude(r => r.Advertisement)
            .Include(x => x.PropertyImageRelations)
                .ThenInclude(r => r.PropertyImage)
            .Include(x => x.FloorRelations)
                .ThenInclude(r => r.Floor)
                    .ThenInclude(f => f.RoomRelations)
                        .ThenInclude(rr => rr.Room)
            .Include(x => x.DealRelations)
                .ThenInclude(r => r.Deal)
            .Include(x => x.LocationRelations)
                .ThenInclude(r => r.Location)
                    .ThenInclude(l => l.CityRelations)
                        .ThenInclude(cr => cr.City)
            .Include(x => x.LocationRelations)
                .ThenInclude(r => r.Location)
                    .ThenInclude(l => l.CityRelations)
                        .ThenInclude(cr => cr.Province)
            .Include(x => x.LocationRelations)
                .ThenInclude(r => r.Location)
                    .ThenInclude(l => l.CityRelations)
                        .ThenInclude(cr => cr.Neighborhood)
            .Include(x => x.TagRelations)
                .ThenInclude(r => r.Tag)
            .FirstOrDefaultAsync(x => x.Id == id);

        if (viewModel.property is null)
        {
            return NotFound();
        }

        viewModel.properties = await _context.Property
            .Where(x => x.Id != id)
            .Include(x => x.AdvertisementRelations)
                .ThenInclude(r => r.Advertisement)
            .Include(x => x.PropertyImageRelations)
                .ThenInclude(r => r.PropertyImage)
            .Include(x => x.FloorRelations)
                .ThenInclude(r => r.Floor)
            .Include(x => x.DealRelations)
                .ThenInclude(r => r.Deal)
            .OrderByDescending(x => x.Id)
            .Take(3)
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
