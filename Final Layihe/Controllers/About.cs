using Microsoft.AspNetCore.Mvc;

namespace Final_Layihe.Controllers;

public class About : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}