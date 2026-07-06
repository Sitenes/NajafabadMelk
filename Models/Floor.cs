using System.ComponentModel.DataAnnotations; // برای Data Annotations

namespace WebSite.Models;

// مدل طبقه
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

    // Relations
    public List<Property_Advertisement_FloorRelation> AdvertisementRelations { get; set; } = new();
    public List<Property_Applicant_FloorRelation> ApplicantRelations { get; set; } = new();
    public List<Property_Deal_FloorRelation> DealRelations { get; set; } = new();
    public List<Property_FloorRelation> PropertyRelations { get; set; } = new();
    public List<Property_Location_FloorRelation> LocationRelations { get; set; } = new();
    public List<Property_PropertyImage_FloorRelation> PropertyImageRelations { get; set; } = new();
    public List<Property_Supplier_FloorRelation> SupplierRelations { get; set; } = new();
    public List<Property_Tag_FloorRelation> TagRelations { get; set; } = new();
}