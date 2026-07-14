namespace WebSite.Models;

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
    public string? region { get; set; }
    public string? GeographicalLocation { get; set; }
    public string? Neighborhood { get; set; }
    public string? FacadeType { get; set; }
    public bool? Renovated { get; set; }
    public bool? Expandable { get; set; }
    public int? Retreat { get; set; }

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

public static class PropertyExtensions
{
    public static string LocalizedTitle(this Property? p, string lang)
    {
        if (p == null) return string.Empty;
        var adv = p.AdvertisementRelations?.FirstOrDefault()?.Advertisement;
        if (adv != null)
        {
            return lang switch
            {
                "fa" => adv.TitleFa ?? adv.TitleEn ?? string.Empty,
                "ar" => adv.TitleAr ?? adv.TitleEn ?? string.Empty,
                _ => adv.TitleEn ?? adv.TitleFa ?? string.Empty
            };
        }
        return p.PropertyCode ?? $"Property #{p.Id}";
    }

    public static string LocalizedDescription(this Property? p, string lang)
    {
        if (p == null) return string.Empty;
        var adv = p.AdvertisementRelations?.FirstOrDefault()?.Advertisement;
        if (adv != null)
        {
            return lang switch
            {
                "fa" => adv.ContentFa ?? string.Empty,
                "ar" => adv.ContentAr ?? string.Empty,
                _ => adv.ContentEn ?? string.Empty
            };
        }
        return p.Description ?? string.Empty;
    }

    public static string LocalizedSummary(this Property? p, string lang)
    {
        var desc = p.LocalizedDescription(lang);
        if (desc.Length > 100) return desc.Substring(0, 97) + "...";
        return desc;
    }

    public static string ImageAddress(this Property? p)
    {
        if (p == null) return "work-1.jpg";
        var img = p.PropertyImageRelations?.FirstOrDefault()?.PropertyImage;
        return img?.ImageUrl ?? "work-1.jpg";
    }

    public static DateTime PublishedAt(this Property? p)
    {
        return p?.CreatedAt ?? DateTime.Now;
    }

    public static string AuthorName(this Property? p)
    {
        return "Admin";
    }

    public static double Price(this Property? p)
    {
        if (p == null) return 0;
        var deal = p.DealRelations?.FirstOrDefault()?.Deal;
        return deal?.SalePrice ?? deal?.DepositPrice ?? 0;
    }

    public static double FinalPrice(this Property? p)
    {
        return p.Price();
    }

    public static int RoomCount(this Property? p)
    {
        if (p == null) return 0;
        return p.FloorRelations?.Sum(x => x.Floor?.RoomsCount ?? 0) ?? 0;
    }

    public static int BathCount(this Property? p)
    {
        return 1; // Default
    }

    public static double AreaValue(this Property? p)
    {
        return p?.Area ?? 0;
    }

    public static List<string> GalleryImages(this Property? p)
    {
        if (p == null || p.PropertyImageRelations == null) return new List<string> { "work-1.jpg" };
        var images = p.PropertyImageRelations.Select(x => x.PropertyImage?.ImageUrl).Where(x => !string.IsNullOrEmpty(x)).ToList();
        return images.Any() ? images! : new List<string> { "work-1.jpg" };
    }

    public static bool HasOffer(this Property? p)
    {
        var deal = p?.DealRelations?.FirstOrDefault()?.Deal;
        return deal != null && (deal.SalePrice < deal.DepositPrice); // Placeholder logic
    }

    public static int PriceDiscountPercent(this Property? p)
    {
        return 0; // Placeholder
    }

    public static string LocationText(this Property? p, string lang)
    {
        if (p == null || p.LocationRelations == null) return "Unknown";
        var loc = p.LocationRelations.FirstOrDefault()?.Location;
        if (loc == null) return "Unknown";
        var rel = loc.CityRelations?.FirstOrDefault();
        if (rel == null) return "Unknown";
        return $"{rel.Province?.Title} - {rel.City?.Title} - {rel.Neighborhood?.Title}";
    }

    public static int TotalCapacity(this Property? p)
    {
        return p?.FloorRelations?.Sum(x => x.Floor?.RoomsCount ?? 0) ?? 0;
    }

    public static string DealType(this Property? p, string lang)
    {
        return p?.DealRelations?.FirstOrDefault()?.Deal?.DealType ?? "-";
    }

    public static double DownPayment(this Property? p)
    {
        return p?.DealRelations?.FirstOrDefault()?.Deal?.DepositPrice ?? 0;
    }

    public static double MonthlyPayment(this Property? p)
    {
        return p?.DealRelations?.FirstOrDefault()?.Deal?.RentPrice ?? 0;
    }

    public static double FinalDownPayment(this Property? p)
    {
        return p.DownPayment();
    }

    public static double FinalMonthlyPayment(this Property? p)
    {
        return p.MonthlyPayment();
    }

    public static List<string> Keywords(this Property? p, string lang)
    {
        if (p == null || p.TagRelations == null) return new List<string>();
        return p.TagRelations.Select(x => x.Tag?.Title).Where(x => !string.IsNullOrEmpty(x)).ToList()!;
    }
}
