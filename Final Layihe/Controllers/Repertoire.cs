using Final_Layihe.DataAccesLayer;
using Final_Layihe.Models;
using Final_Layihe.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Final_Layihe.Controllers;

// Controller adının sonuna "Controller" əlavə etmək standartdır
public class RepertoireController : Controller
{
    private readonly AppDbContext _db;

    public RepertoireController(AppDbContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        
        RepertoireVM repertoire = new RepertoireVM
        {
            children = _db.Children.ToList(),
            tamasalar = _db.tamasalar.ToList(),
        }; 

        return View(repertoire);
    }
}