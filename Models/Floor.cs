namespace WebSite.Models;

public class Floor
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedByUserId { get; set; }
    public string? FloorNo { get; set; }
    public double? Infrastructure { get; set; }
    public int? RoomsCount { get; set; }
    public int? ParkingCount { get; set; }
    public double? CommercialArea { get; set; }
    public string? WaterType { get; set; }
    public string? ElectricityType { get; set; }
    public string? GasType { get; set; }
    public string? LandlineType { get; set; }
    public string? Description { get; set; }
    public string? PrivateDescription { get; set; }
    public string? Status { get; set; }
    public int? Numberofkitchens { get; set; }
    public double? KitchenArea { get; set; }
    public string? Staircase { get; set; }
    public string? Yard { get; set; }
    public double? YardArea { get; set; }
    public string? Wardrobe { get; set; }
    public string? Cabbie { get; set; }
    public string? FloorCovering { get; set; }
    public string? BrightnessLevel { get; set; }
    public int? WCCount { get; set; }
    public double? WCArea { get; set; }
    public double? LivingRoomArea { get; set; }
    public string? HeatingSystem { get; set; }
    public string? CoolingSystem { get; set; }
    public int? Elevator { get; set; }
    public string? OtherFacilities { get; set; }

    public List<Property_Advertisement_FloorRelation> AdvertisementRelations { get; set; } = new();
    public List<Property_Applicant_FloorRelation> ApplicantRelations { get; set; } = new();
    public List<Property_Deal_FloorRelation> DealRelations { get; set; } = new();
    public List<Property_FloorRelation> PropertyRelations { get; set; } = new();
    public List<Property_Location_FloorRelation> LocationRelations { get; set; } = new();
    public List<Property_PropertyImage_FloorRelation> PropertyImageRelations { get; set; } = new();
    public List<Property_Supplier_FloorRelation> SupplierRelations { get; set; } = new();
    public List<Property_Tag_FloorRelation> TagRelations { get; set; } = new();
    public List<Floor_RoomRelation> RoomRelations { get; set; } = new();
}