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

    public async Task<IActionResult> Index(string? search, string? sortOrder, string? usageType, double? minPrice, double? maxPrice, int page = 1)
    {
        const int pageSize = 9;
        page = Math.Max(page, 1);

        ViewData["CurrentFilter"] = search;
        ViewData["PriceSortParm"] = sortOrder == "price_asc" ? "price_desc" : "price_asc";
        ViewData["DateSortParm"] = sortOrder == "date_asc" ? "date_desc" : "date_asc";

        var query = _context.Property.AsQueryable();

        // Filtering
        if (!string.IsNullOrEmpty(search))
        {
            query = query.Where(s => s.PropertyCode!.Contains(search) || s.Description!.Contains(search) || s.Address!.Contains(search));
        }

        if (!string.IsNullOrEmpty(usageType))
        {
            query = query.Where(x => x.UsageType == usageType);
        }

        if (minPrice.HasValue)
        {
            query = query.Where(x => x.DealRelations.Any(r => r.Deal!.SalePrice >= minPrice.Value));
        }

        if (maxPrice.HasValue)
        {
            query = query.Where(x => x.DealRelations.Any(r => r.Deal!.SalePrice <= maxPrice.Value));
        }

        // Sorting
        query = sortOrder switch
        {
            "price_asc" => query.OrderBy(s => s.DealRelations.OrderBy(r => r.Deal!.SalePrice).FirstOrDefault()!.Deal!.SalePrice),
            "price_desc" => query.OrderByDescending(s => s.DealRelations.OrderByDescending(r => r.Deal!.SalePrice).FirstOrDefault()!.Deal!.SalePrice),
            "date_asc" => query.OrderBy(s => s.CreatedAt),
            _ => query.OrderByDescending(s => s.CreatedAt),
        };

        var viewModel = new propertiesViewModel
        {
            TotalCount = await query.CountAsync(),
            CurrentPage = page,
            PageSize = pageSize,
            properties = await query
                .Include(x => x.AdvertisementRelations).ThenInclude(r => r.Advertisement)
                .Include(x => x.PropertyImageRelations).ThenInclude(r => r.PropertyImage)
                .Include(x => x.FloorRelations).ThenInclude(r => r.Floor).ThenInclude(f => f.RoomRelations).ThenInclude(rr => rr.Room)
                .Include(x => x.DealRelations).ThenInclude(r => r.Deal)
                .Include(x => x.LocationRelations).ThenInclude(r => r.Location).ThenInclude(l => l.CityRelations).ThenInclude(cr => cr.City)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync(),
            staticDatas = await _context.StaticDatas.Include(x => x.Group).ToListAsync()
        };
        return View(viewModel);
    }

    public IActionResult Create()
    {
        return View(new PropertyCreateEditViewModel());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(PropertyCreateEditViewModel model)
    {
        if (ModelState.IsValid)
        {
            model.Property.CreatedAt = DateTime.Now;
            _context.Property.Add(model.Property);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(model);
    }

    public async Task<IActionResult> Edit(int id)
    {
        var property = await _context.Property
            .Include(x => x.FloorRelations).ThenInclude(r => r.Floor)
            .FirstOrDefaultAsync(x => x.Id == id);

        if (property == null) return NotFound();

        var viewModel = new PropertyCreateEditViewModel
        {
            Property = property,
            Floors = property.FloorRelations.Select(r => r.Floor!).ToList()
        };
        return View(viewModel);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(PropertyCreateEditViewModel model)
    {
        if (ModelState.IsValid)
        {
            _context.Update(model.Property);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Delete(int id)
    {
        var property = await _context.Property.FindAsync(id);
        if (property != null)
        {
            _context.Property.Remove(property);
            await _context.SaveChangesAsync();
        }
        return RedirectToAction(nameof(Index));
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
