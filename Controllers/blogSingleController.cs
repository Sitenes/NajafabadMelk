using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebSite.Models;

namespace WebSite.Controllers;

public class blogSingleController : Controller
{
    private readonly RealEstateDbContext _context;

    public blogSingleController(RealEstateDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index(int? id)
    {
        var viewModel = new blogSingleViewModel();
        viewModel.staticDatas = await _context.staticDatas.Include(x => x.Group).ToListAsync();

        var publishedArticles = _context.Articles
            .Where(x => x.IsPublished)
            .OrderByDescending(x => x.PublishedAt);

        viewModel.article = id.HasValue
            ? await publishedArticles.FirstOrDefaultAsync(x => x.Id == id.Value)
            : await publishedArticles.FirstOrDefaultAsync();

        if (viewModel.article == null)
        {
            return RedirectToAction("Index", "blog");
        }

        viewModel.recentArticles = await _context.Articles
            .Where(x => x.IsPublished && x.Id != viewModel.article.Id)
            .OrderByDescending(x => x.PublishedAt)
            .Take(4)
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
