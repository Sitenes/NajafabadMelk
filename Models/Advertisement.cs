using System.ComponentModel.DataAnnotations; // برای Data Annotations

// مدل اگهی
public class Advertisement
{
    public int Id { get; set; } // کلید اصلی

    [Required] // الزامی بودن فیلد
    public string Title { get; set; }
    public string Description { get; set; }
    public int HouseId { get; set; } // کلید خارجی برای ارتباط با House
    public House House { get; set; } // ارجاع به مدل منزل
    public List<string> Keywords { get; set; } = new List<string>(); // لیست کلید واژه ه
}
