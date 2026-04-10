using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // برای Data Annotations


// مدل منزل
public class House
{
    public int Id { get; set; } // کلید اصلی

    public List<string> ImageUrls { get; set; } = new List<string>(); // لیست عکس ها

    public DateTime RegistrationTime { get; set; } // زمان ثبت

    public DateTime ConstructionTime { get; set; } // زمان ساخت

    public bool HasParking { get; set; } // پارکینگ (دارد – ندارد)

    public int? ParkingCount { get; set; } // تعداد پارکینگ ( Nullable چون اگر پارکینگ نداشته باشد، این فیلد خالی خواهد بود)

    public string Deed { get; set; } // سند

    public string ConstructionStatus { get; set; } // وضعیت ساخت

    public bool HasPool { get; set; } // استخر (دارد – ندارد)

    public double? PoolArea { get; set; } // متراژ استخر (Nullable)

    public int? TreeCount { get; set; } // تعداد درخت (Nullable)

    public bool HasElevator { get; set; } // اسانسور (دارد – ندارد)

    public int? FloorCount { get; set; } // تعداد طبقه (Nullable)

    public List<Floor> Floors { get; set; } = new List<Floor>(); // لیست طبقات
}
