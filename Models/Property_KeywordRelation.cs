namespace WebSite.Models;

public class Property_KeywordRelation
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedByUserId { get; set; }
    public int? PropertyId { get; set; }
    public int? KeywordId { get; set; }
}