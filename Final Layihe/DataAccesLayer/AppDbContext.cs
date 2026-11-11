using Final_Layihe.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Layihe.DataAccesLayer;

public class AppDbContext : DbContext

{
    public AppDbContext(DbContextOptions options) : base(options) {}

    
    public DbSet<Tamasalar> tamasalar { get; set; }
    public DbSet<Children> Children { get; set; }
    public DbSet<ContactInfo> ContactInfo { get; set; }
    public DbSet<ContactMessage>  ContactMessage { get; set; }
}


  

