namespace WebSite.Models;

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