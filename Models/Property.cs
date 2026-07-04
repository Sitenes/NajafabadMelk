namespace WebSite.Models;

// مدل ملک
public class Property
{
    public string Id { get; set; }

    public string? ApplicantId { get; set; }

    public long Row { get; set; }

    public int ComeInSearchResult { get; set; }

    public int DetailsSeenCount { get; set; }

    public int? RegisterDate { get; set; }

    public int? ValidityPriod { get; set; }

    public string? LandLordId { get; set; }

    public string UsageType { get; set; }

    public string? PropertyType { get; set; }

    public string? Adjective { get; set; }

    public int? Space { get; set; }

    public int? Infrastructure { get; set; }

    public string? SalePriceCalcMode { get; set; }

    public short StoreyNo { get; set; }

    public short StoreyCount { get; set; }

    public short UnitsCount { get; set; }

    public short RoomsCount { get; set; }

    public int? LocationId { get; set; }

    public string? PhysicalAddress { get; set; }

    public string? PropertyArea { get; set; }

    public bool ForSale { get; set; }

    public long? SalePrice { get; set; }

    public long? LoanPrice { get; set; }

    public long? PaymentPrice { get; set; }

    public string? Aggregation { get; set; }

    public string? CertificateType { get; set; }

    public string? Dongs { get; set; }

    public long? MortgagePrice1 { get; set; }

    public bool ForRent { get; set; }

    public long? RentPrice1 { get; set; }

    public long? MortgagePrice2 { get; set; }

    public long? RentPrice2 { get; set; }

    public string RentPrefer { get; set; }

    public bool ForPresale { get; set; }

    public long? PreSalePrice { get; set; }

    public long? PrePayPrice { get; set; }

    public int? DeliveryDate { get; set; }

    public bool ForExchange { get; set; }

    public string? ExhchangeByAreas { get; set; }

    public string? ExchangeDescription { get; set; }

    public string? Direction { get; set; }

    public string? Frontage { get; set; }

    public string? Floor { get; set; }

    public string? KitchenService { get; set; }

    public string? Water { get; set; }

    public string? Electricity { get; set; }

    public string? Gas { get; set; }

    public string? Landline { get; set; }

    public string? PropertyStatus { get; set; }

    public string? PropertyAge { get; set; }

    public int? CommercialMeter { get; set; }

    public bool Deadlock { get; set; }

    public bool Parking { get; set; }

    public short? Open { get; set; }

    public bool Store { get; set; }

    public short? Balcony { get; set; }

    public string? Plaque { get; set; }

    public string? Description { get; set; }

    public string? PrivateDescription { get; set; }

    public int? LastAccessed { get; set; }

    public int? LastModified { get; set; }

    public int LastManualUpdate { get; set; }

    public int? Grade { get; set; }

    public string? CommissionPercent { get; set; }

    public long? FilePrice { get; set; }

    public string? Experiments { get; set; }

    public string? RegistrarAgency { get; set; }

    public string? RegistrarUser { get; set; }

    public bool OwnerIsResident { get; set; }

    public bool Court { get; set; }

    public bool Elec3Phase { get; set; }

    public bool InputSeparate { get; set; }

    public bool ForAssociate { get; set; }

    public string? PreSaleDesc { get; set; }

    public bool Elevator { get; set; }

    public string? PriceCalcMode { get; set; }

    public long? LikeCount { get; set; }

    public long? ShareCount { get; set; }

    public int? LastSyncDate { get; set; }

    public long? ComeInSearchResultInWebsite { get; set; }

    public long? DetailsSeenCountInWebsite { get; set; }

    public string? ReservedField { get; set; }

    public bool ShortTermRent { get; set; }

    public int BrinkValue { get; set; }

    public short? CeilingHeight { get; set; }

    public bool IsArchived { get; set; }

    public string? Section { get; set; }

    public string? Sketch { get; set; }

    public int PassageWidth { get; set; }

    public string? AssociateDescription { get; set; }

    public string? ModifiedValue { get; set; }

    public string? Source { get; set; }

    public string Cooling { get; set; }

    public string Heating { get; set; }

    public int? PropertyAgeYear { get; set; }

    public bool LandlordCanceled { get; set; }

    public short? LandlordCanceledInWebsite { get; set; }

    public short? DeletedInWebsite { get; set; }

    public bool Assigned { get; set; }

    public short? AssignedInWebsite { get; set; }

    public float? Latitude { get; set; }

    public float? Longitude { get; set; }

    public string? Service { get; set; }

    public string? Dimensions { get; set; }

    public short? MarkAsDeletedInWebsite { get; set; }

    public string? CommercialCertificate { get; set; }

    public string? RelatedInformation { get; set; }

    public string? CurrentResidentPhoneNumber { get; set; }

    public string? EstateStatus { get; set; }

    public bool IsConvertible { get; set; }

    public bool IgnoreWebSite { get; set; }

    public bool IsConfirmed { get; set; }

    public bool ShowInWebsite { get; set; }

    public sbyte RegistrarDevice { get; set; }

    public string DivarToken { get; set; }

    // Relations -------------------------

    public List<Floor> Floors { get; set; } = new();

    public List<Picture> Pictures { get; set; } = new();

    public List<InsertedPropertyFacility> Facilities { get; set; } = new();

    public List<InsertedPropertyExtraItem> ExtraItems { get; set; } = new();

    public List<InsertedPropertyTag> Tags { get; set; } = new();
}
