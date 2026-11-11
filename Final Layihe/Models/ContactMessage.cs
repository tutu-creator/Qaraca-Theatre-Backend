namespace Final_Layihe.Models;

public class ContactMessage
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Message { get; set; }
    public DateTime SentAt { get; set; }
}