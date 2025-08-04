using Microsoft.AspNetCore.Mvc;

namespace MyMvcApp.Controllers;

public class RegistersController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Registers";
        return View();
    }
}
