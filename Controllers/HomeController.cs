using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using hotels.Models;

namespace hotels.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }
    public IActionResult Offers()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }
}
