namespace WebSite.Models;

// مدل موقعیت مکانی
public class Location
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedByUserId { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }

    // Relations
    public List<Location_CityRelation> CityRelations { get; set; } = new();
}