using Microsoft.EntityFrameworkCore;
using WebSite.Models;

namespace WebSite.Models;

public static class ModelExtensions
{
    // User Extensions
    public static string LocalizedName(this User? user, string lang)
    {
        if (user == null) return string.Empty;
        return $"{user.FirstName} {user.LastName}";
    }

    public static string LocalizedExpert(this User? user, string lang)
    {
        return "Real Estate Agent";
    }

    public static string ImageAddress(this User? user)
    {
        return "person_1.jpg";
    }

    // Property Extensions (General)
    public static string LocalizedTitle(this Property? p, string lang)
    {
        if (p == null) return string.Empty;
        // Search in AdvertisementRelations
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