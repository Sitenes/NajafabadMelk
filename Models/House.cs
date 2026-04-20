// مدل منزل
public class House
{
    public int Id { get; set; }
    public List<HouseImage> Images { get; set; } = new List<HouseImage>();
    public string? PropertyCode { get; set; }
    public string? City { get; set; }
    public string? District { get; set; }
    public string? Neighborhood { get; set; }
    public string? AddressLine { get; set; }
    public double? LandArea { get; set; }
    public double? BuildingArea { get; set; }
    public int? UnitNumber { get; set; }
    public int? YearRenovated { get; set; }
    public string? NearbyFacilities { get; set; }
    public string? AmenitiesFa { get; set; }
    public string? AmenitiesEn { get; set; }
    public string? AmenitiesAr { get; set; }
    public DateTime RegistrationTime { get; set; }
    public DateTime ConstructionTime { get; set; }
    public bool HasParking { get; set; }
    public int? ParkingCount { get; set; }
    public string Deed { get; set; }
    public string ConstructionStatus { get; set; }
    public bool HasPool { get; set; }
    public double? PoolArea { get; set; }
    public int? TreeCount { get; set; }
    public bool HasElevator { get; set; }
    public int? FloorCount { get; set; }

    //Relation --------------------------
    public List<Floor> Floors { get; set; } = new List<Floor>();
}