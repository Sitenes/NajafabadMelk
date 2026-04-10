using System.ComponentModel.DataAnnotations; // برای Data Annotations

// مدل طبقه
public class Floor
{
    public int Id { get; set; } // کلید اصلی

    public double Area { get; set; } // متراژ

    public int RoomCount { get; set; } // تعداد اتاق

    public int Capacity { get; set; } // ظرفیت

    public bool HasBalcony { get; set; } // بالکن (دارد – ندارد)

    public double? BalconyArea { get; set; } // متراژ بالکن (Nullable)

    public bool HasStorage { get; set; } // انبار (دارد – ندارد)

    public double? StorageArea { get; set; } // متراژ انبار (Nullable)

    public string ConstructionDirection { get; set; } // جهت ساخت

    public string CoolingStatus { get; set; } // وضعیت سرمایشی

    public string HeatingStatus { get; set; } // وضعیت گرمایشی

    public string HotWaterStatus { get; set; } // وضعیت تامین آب گرم
    public List<string> FloorMaterials { get; set; } = new List<string>(); // لیست جنس کف

    public List<string> WallMaterials { get; set; } = new List<string>(); // لیست جنس دیواره ها

    public List<string> ToiletTypes { get; set; } = new List<string>(); // لیست سرویس بهداشتی
}
