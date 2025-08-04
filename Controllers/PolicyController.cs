using Microsoft.AspNetCore.Mvc;

namespace MyMvcApp.Controllers;

public class PolicyController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Policy";
        return View();
    }
}
