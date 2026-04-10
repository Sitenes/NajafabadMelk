using System.ComponentModel.DataAnnotations;

public class Status
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Value { get; set; }
    public int Group { get; set; }
}

public class HouseImage
{
    public int Id { get; set; }
    public string Url { get; set; }

    //Relation --------------------------
    public int HouseId { get; set; }
    public House House { get; set; }
}
