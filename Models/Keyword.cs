using System.ComponentModel.DataAnnotations; // برای Data Annotations

public class Keyword
{
    public int Id { get; set; }
    public string Content { get; set; }

    //Relation --------------------------
    public List<Advertisement> Advertisements { get; set; } = new List<Advertisement>();
}