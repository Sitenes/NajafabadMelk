namespace WebSite.Models;

// مدل ملک
public class Property
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedByUserId { get; set; }
    public string? PropertyCode { get; set; }
    public string? UsageType { get; set; }
    public string? PropertyType { get; set; }
    public string? ConstructionType { get; set; }
    public string? CertificateType { get; set; }
    public string? FrontageType { get; set; }
    public string? DirectionType { get; set; }
    public string? AggregationType { get; set; }
    public int? ConstructionYear { get; set; }
    public double? Area { get; set; }
    public double? Length { get; set; }
    public double? Width { get; set; }
    public double? PassageWidth { get; set; }
    public string? Address { get; set; }
    public bool? IsDeadlock { get; set; }
    public bool? InputSeparate { get; set; }
    public string? Description { get; set; }
    public string? PrivateDescription { get; set; }
    public string? Status { get; set; }

    // Relations
    public List<Property_Advertisement_FloorRelation> AdvertisementRelations { get; set; } = new();
    public List<Property_Applicant_FloorRelation> ApplicantRelations { get; set; } = new();
    public List<Property_Deal_FloorRelation> DealRelations { get; set; } = new();
    public List<Property_FloorRelation> FloorRelations { get; set; } = new();
    public List<Property_Location_FloorRelation> LocationRelations { get; set; } = new();
    public List<Property_PropertyImage_FloorRelation> PropertyImageRelations { get; set; } = new();
    public List<Property_Supplier_FloorRelation> SupplierRelations { get; set; } = new();
    public List<Property_Tag_FloorRelation> TagRelations { get; set; } = new();
}
