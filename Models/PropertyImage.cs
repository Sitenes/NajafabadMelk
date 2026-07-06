namespace WebSite.Models;

public class PropertyImage
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedByUserId { get; set; }
    public string? ImageUrl { get; set; }
    public string? Thumbnail { get; set; }
    public int? SortOrder { get; set; }

    // Relations
    public List<Property_PropertyImage_FloorRelation> PropertyRelations { get; set; } = new();
}