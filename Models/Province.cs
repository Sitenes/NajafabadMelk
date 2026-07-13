namespace WebSite.Models;

public class Province
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedByUserId { get; set; }
    public string? Title { get; set; }
}