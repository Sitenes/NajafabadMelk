using System.ComponentModel.DataAnnotations; // برای Data Annotations

// مدل اگهی
public class Advertisement
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }

    //Relation----------------------------------------
    public int HouseId { get; set; }
    public House House { get; set; }

    public int DealId { get; set; }
    public Deal Deal { get; set; }

    public List<Keyword> Keywords { get; set; } = new List<Keyword>();
}