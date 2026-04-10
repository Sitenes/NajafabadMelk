// مدل منزل
public class House
{
    public int Id { get; set; }
    public List<HouseImage> Images { get; set; } = new List<HouseImage>();
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