namespace WebSite.Models;

public class Location_CityRelation
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedByUserId { get; set; }
    public int? LocationId { get; set; }
    public Location? Location { get; set; }
    public int? CityId { get; set; }
    public City? City { get; set; }
    public int? NeighborhoodId { get; set; }
    public Neighborhood? Neighborhood { get; set; }
    public int? ProvinceId { get; set; }
    public Province? Province { get; set; }
}

public class Property_Advertisement_FloorRelation
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedByUserId { get; set; }
    public int? PropertyId { get; set; }
    public Property? Property { get; set; }
    public int? AdvertisementId { get; set; }
    public Advertisement? Advertisement { get; set; }
    public int? FloorId { get; set; }
    public Floor? Floor { get; set; }
}

public class Property_Applicant_FloorRelation
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedByUserId { get; set; }
    public int? PropertyId { get; set; }
    public Property? Property { get; set; }
    public int? ApplicantId { get; set; }
    public Applicant? Applicant { get; set; }
    public int? FloorId { get; set; }
    public Floor? Floor { get; set; }
}

public class Property_Deal_FloorRelation
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedByUserId { get; set; }
    public int? PropertyId { get; set; }
    public Property? Property { get; set; }
    public int? DealId { get; set; }
    public Deal? Deal { get; set; }
    public int? FloorId { get; set; }
    public Floor? Floor { get; set; }
}

public class Property_FloorRelation
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedByUserId { get; set; }
    public int? PropertyId { get; set; }
    public Property? Property { get; set; }
    public int? FloorId { get; set; }
    public Floor? Floor { get; set; }
}

public class Property_Location_FloorRelation
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedByUserId { get; set; }
    public int? PropertyId { get; set; }
    public Property? Property { get; set; }
    public int? LocationId { get; set; }
    public Location? Location { get; set; }
    public int? FloorId { get; set; }
    public Floor? Floor { get; set; }
}

public class Property_PropertyImage_FloorRelation
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedByUserId { get; set; }
    public int? PropertyId { get; set; }
    public Property? Property { get; set; }
    public int? PropertyImageId { get; set; }
    public PropertyImage? PropertyImage { get; set; }
    public int? FloorId { get; set; }
    public Floor? Floor { get; set; }
}

public class Property_Supplier_FloorRelation
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedByUserId { get; set; }
    public int? PropertyId { get; set; }
    public Property? Property { get; set; }
    public int? SupplierId { get; set; }
    public Supplier? Supplier { get; set; }
    public int? FloorId { get; set; }
    public Floor? Floor { get; set; }
}

public class Property_Tag_FloorRelation
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedByUserId { get; set; }
    public int? PropertyId { get; set; }
    public Property? Property { get; set; }
    public int? TagId { get; set; }
    public Tag? Tag { get; set; }
    public int? FloorId { get; set; }
    public Floor? Floor { get; set; }
}

public class Property_KeywordRelation
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedByUserId { get; set; }
    public int? PropertyId { get; set; }
    public int? KeywordId { get; set; }
}