using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Final_Layihe.Models;

namespace Final_Layihe.Controllers;

public class Home : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    
  
    public IActionResult Error()
    {
        return View();
    }
}