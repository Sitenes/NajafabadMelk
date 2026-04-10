using System.ComponentModel.DataAnnotations; // برای Data Annotations

public class Keyword
{
    public int Id { get; set; }
    public string ContentFa { get; set; }
    public string ContentEn { get; set; }
    public string ContentAr { get; set; }

    //Relation --------------------------
    public List<Advertisement> Advertisements { get; set; } = new List<Advertisement>();
}