using Final_Layihe.DataAccesLayer;
using Final_Layihe.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final_Layihe.Controllers;

public class Contact : Controller
{
    private readonly AppDbContext _db;
    public Contact(AppDbContext db)
    {
        _db = db;
    }

    // GET
    public IActionResult Index()
    {
        ContactInfo contactInfo = _db.ContactInfo.FirstOrDefault();
        return View(contactInfo);
    }

    // POST
    [HttpPost]
    public IActionResult SendMessage(ContactMessage model)
    {
        model.SentAt = DateTime.Now;
        _db.ContactMessage.Add(model);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
}