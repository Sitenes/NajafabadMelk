using System.ComponentModel.DataAnnotations; // برای Data Annotations

public class StaticData
{
    public String Id { get; set; }
    public String? StringContentFa { get; set; }
    public String? StringContentEn { get; set; }
    public String? StringContentAr { get; set; }
    public int? BestCountOfNumber { get; set; }
    public String? ImageAdress { get; set; }
    public string Name { get; set; }
    public int GroupId { get; set; }
    public StaticDataGroup Group { get; set; }
}

public class StaticDataGroup
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public string Page { get; set; }
    public string Container { get; set; }
}

public static class StaticDataExtensions
{
    // کلمه کلیدی this اینجا باعث می‌شود این متد به عنوان یک متد داخلی به StaticData اضافه شود
    public static string LocalizedContent(this StaticData? adv, string lang)
    {
        if (adv == null) return string.Empty;

        return lang switch
        {
            "fa" => adv.StringContentFa ?? adv.StringContentEn ?? "بدون محتوا",
            "ar" => adv.StringContentAr ?? adv.StringContentEn ?? "بدون محتوا",
            _ => adv.StringContentEn ?? adv.StringContentFa ?? "No Content"
        };
    }
}
