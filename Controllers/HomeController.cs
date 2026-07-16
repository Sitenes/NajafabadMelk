using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebSite.Models;
using WebSite.ViewModels;

namespace WebSite.Controllers;

public class HomeController : Controller
{
    private readonly RealEstateDbContext _context;

    public HomeController(RealEstateDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var ViewModel = new HomeViewModel();
        var totalProperty = await _context.Property.CountAsync();
        ViewModel.propertyCount = totalProperty;
        int[] ids = { 27797, 31581, 38238, 41317, 30634, 31010, 33014, 46149, 47436, 26137, 28814, 28829 };

        ViewModel.properties = await _context.Property
            .Include(x => x.AdvertisementRelations)
                .ThenInclude(r => r.Advertisement)
            .Include(x => x.PropertyImageRelations)
                .ThenInclude(r => r.PropertyImage)
            .Include(x => x.DealRelations)
                .ThenInclude(r => r.Deal)
            .Include(x => x.LocationRelations)
                .ThenInclude(r => r.Location)
                    .ThenInclude(l => l.CityRelations)
                        .ThenInclude(cr => cr.City)
            .Where(x => ids.Contains(x.Id))
            .ToListAsync();

        ViewModel.staticDatas = await _context.StaticDatas.Include(x => x.Group).ToListAsync();
        ViewModel.agents = await _context.Agents.Take(4).ToListAsync();
        ViewModel.articles = await _context.Articles
            .OrderByDescending(x => x.PublishedAt)
            .Take(3)
            .ToListAsync();
        return View(ViewModel);
    }
}
