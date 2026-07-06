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
        var totalProperties = await _context.Properties.CountAsync();
        ViewModel.propertyCount = totalProperties;

        ViewModel.properties = await _context.Properties
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
            .OrderBy(a => a.Id) 
            .Take(10)
            .ToListAsync();

        ViewModel.staticDatas = await _context.StaticDatas.Include(x => x.Group).ToListAsync();
        ViewModel.agents = await _context.Users.Take(4).ToListAsync();
        ViewModel.articles = await _context.Properties
            .Include(x => x.AdvertisementRelations)
                .ThenInclude(r => r.Advertisement)
            .Include(x => x.PropertyImageRelations)
                .ThenInclude(r => r.PropertyImage)
            .Take(3)
            .ToListAsync(); 
        return View(ViewModel);
    }
}
