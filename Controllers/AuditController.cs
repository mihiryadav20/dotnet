using Microsoft.AspNetCore.Mvc;

namespace MyMvcApp.Controllers;

public class AuditController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Audit Logs";
        return View();
    }
}
