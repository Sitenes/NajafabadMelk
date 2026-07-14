namespace WebSite.Models;

public class Advertisement
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedByUserId { get; set; }
    public string? TitleFa { get; set; }
    public string? TitleEn { get; set; }
    public string? TitleAr { get; set; }
    public string? ContentFa { get; set; }
    public string? ContentAr { get; set; }
    public string? ContentEn { get; set; }

    public int? ValidityPeriod { get; set; }
    public string? Status { get; set; }

    public List<Property_Advertisement_FloorRelation> PropertyRelations { get; set; } = new();
}