namespace WebSite.Models;

// مدل موقعیت مکانی
public class Location
{
    public long Id { get; set; }

    public long? Parent { get; set; }

    public string? FarsiName { get; set; }

    public string? EnglishName { get; set; }

    public string? Code { get; set; }

    public string? PostalCode { get; set; }

    public sbyte Level { get; set; }

    public float? Latitude { get; set; }

    public float? Longitude { get; set; }

    public short? IsCapital { get; set; }

    public string DivarAreas { get; set; }
}