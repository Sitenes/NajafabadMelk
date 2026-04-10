using System.ComponentModel.DataAnnotations; // برای Data Annotations

// مدل طبقه
public class Floor
{
    public int Id { get; set; }
    public double Area { get; set; }
    public int RoomCount { get; set; }
    public int Capacity { get; set; }
    public bool HasBalcony { get; set; }
    public double? BalconyArea { get; set; }
    public bool HasStorage { get; set; }
    public double? StorageArea { get; set; }
    public string ConstructionDirection { get; set; }
    public string CoolingStatus { get; set; }
    public string HeatingStatus { get; set; }
    public string HotWaterStatus { get; set; }

    //Relation ---------------------------
    public int ToiletTypeId { get; set; }
    public Status ToiletType { get; set; }

    public int HouseId { get; set; }
    public House House { get; set; }

    public List<Material> FloorMaterials { get; set; } = new List<Material>();
}