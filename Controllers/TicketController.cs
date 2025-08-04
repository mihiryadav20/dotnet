using Microsoft.AspNetCore.Mvc;

namespace MyMvcApp.Controllers;

public class TicketController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Ticket";
        return View();
    }
}
