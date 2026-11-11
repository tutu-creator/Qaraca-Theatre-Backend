using Microsoft.AspNetCore.Mvc;

namespace Final_Layihe.Areas.Admin.Controllers;

[Area("Admin")]
public class DashboardController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}

