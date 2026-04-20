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
            .Where(x => x.Deal.HaveOffer && x.Deal.DealTypeId == 1)
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
                .Where(x => x.Deal.HaveOffer && x.Deal.DealTypeId == 1)
                .ToListAsync();
            ViewModel.advertisementsCount = ViewModel.advertisements.Count;
        }


        ViewModel.staticDatas = await _context.staticDatas.Include(x => x.Group).ToListAsync();
        ViewModel.agents = await _context.Agents
            .OrderBy(x => Guid.NewGuid())
            .Take(4)
            .ToListAsync();
        ViewModel.articles = await _context.Articles
            .Where(x => x.IsPublished)
            .OrderByDescending(x => x.PublishedAt)
            .Take(4)
            .ToListAsync();
        return View(ViewModel);
    }
}
