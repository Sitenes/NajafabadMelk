namespace WebSite.Models;

public class City
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedByUserId { get; set; }
    public int? ProvinceId { get; set; }
    public string? Title { get; set; }
}

public class Province
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedByUserId { get; set; }
    public string? Title { get; set; }
}

public class Neighborhood
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedByUserId { get; set; }
    public int? CityId { get; set; }
    public string? Title { get; set; }
}