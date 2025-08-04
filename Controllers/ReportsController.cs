using Microsoft.AspNetCore.Mvc;

namespace MyMvcApp.Controllers;

public class ReportsController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Reports";
        return View();
    }
}
