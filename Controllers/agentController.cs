using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebSite.Models;

namespace WebSite.Controllers;

public class agentController : Controller
{
    private readonly RealEstateDbContext _context;

    public agentController(RealEstateDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var viewModel = new agentViewModel();
        viewModel.staticDatas = await _context.staticDatas.Include(x => x.Group).ToListAsync();
        viewModel.agents = await _context.Agents.ToListAsync();
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
