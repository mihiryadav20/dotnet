using Microsoft.AspNetCore.Mvc;

namespace MyMvcApp.Controllers;

public class OrganizationController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Organization";
        return View();
    }
}
