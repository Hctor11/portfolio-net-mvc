using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using net_portfolio.Models;

namespace net_portfolio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var persona = new Persona(){
            Name = "Hector R",
            Age = "222"
        };
        ViewBag.Name = "Hector Rivera";
        return View(persona);
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
