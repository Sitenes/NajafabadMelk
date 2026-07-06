using System.ComponentModel.DataAnnotations; // برای Data Annotations

namespace WebSite.Models;

// مدل معامله
public class Deal
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedByUserId { get; set; }
    public string? DealType { get; set; }
    public double? SalePrice { get; set; }
    public double? DepositPrice { get; set; }
    public double? RentPrice { get; set; }
    public double? MortgagePrice { get; set; }
    public double? PreSalePrice { get; set; }
    public string? Description { get; set; }
    public string? Status { get; set; }

    // Relations
    public List<Property_Deal_FloorRelation> PropertyRelations { get; set; } = new();
}