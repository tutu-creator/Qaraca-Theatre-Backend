using Microsoft.EntityFrameworkCore;

namespace Final_Layihe.Models;

public class Tamasalar
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; }
    
    public string?  Price { get; set; }
    
}