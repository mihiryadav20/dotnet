using Microsoft.AspNetCore.Mvc;

namespace MyMvcApp.Controllers;

public class DashboardController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Dashboard";
        return View();
    }
}
