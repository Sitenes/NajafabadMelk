using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebSite.Models;

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
        var totalAdvertisements = await _context.Advertisements.CountAsync();
        if (totalAdvertisements < 5)
        {
            ViewModel.advertisements = await _context.Advertisements
            .Include(x => x.Keywords)
            .Include(x => x.Deal)
            .Include(x => x.House)
            .ThenInclude(x => x.Images)
            .Where(x => x.Deal.HaveOffer)
            .ToListAsync();
            ViewModel.advertisementsCount = totalAdvertisements;
        }
        else
        {
            ViewModel.advertisements = await _context.Advertisements
                .OrderBy(a => Guid.NewGuid()) // مرتب‌سازی تصادفی
                .Take(10)
                .Include(x => x.Keywords)
                .Include(x => x.Deal)
                .Include(x => x.House)
                .ThenInclude(x => x.Images)
                .Where(x => x.Deal.HaveOffer)
                .ToListAsync();
            ViewModel.advertisementsCount = 3;
        }


        ViewModel.staticDatas = await _context.staticDatas.Include(x => x.Group).ToListAsync();
        ViewModel.agents = await _context.Agents.Take(4).ToListAsync();
        return View(ViewModel);
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
