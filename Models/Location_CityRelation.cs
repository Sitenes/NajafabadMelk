namespace WebSite.Models;

public class Location_CityRelation
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedByUserId { get; set; }
    public int? LocationId { get; set; }
    public Location? Location { get; set; }
    public int? CityId { get; set; }
    public City? City { get; set; }
    public int? NeighborhoodId { get; set; }
    public Neighborhood? Neighborhood { get; set; }
    public int? ProvinceId { get; set; }
    public Province? Province { get; set; }
}