namespace WebSite.Models;

public class Floor_RoomRelation
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedByUserId { get; set; }
    public int? FloorId { get; set; }
    public Floor? Floor { get; set; }
    public int? RoomId { get; set; }
    public Room? Room { get; set; }
}