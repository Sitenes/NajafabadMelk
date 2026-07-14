using System.ComponentModel.DataAnnotations;

namespace WebSite.Models;

public class Room
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedByUserId { get; set; }
    public int? RoomArea { get; set; }
    public double? Length { get; set; }
    public double? Width { get; set; }
    public int? WindowCount { get; set; }
    public string? Wardrobe { get; set; }
    public string? Heating { get; set; }
    public string? CoolingSystem { get; set; }
    public string? Description { get; set; }
    public string? PrivateDescription { get; set; }

    // Relations
    public List<Floor_RoomRelation> FloorRelations { get; set; } = new();
}
