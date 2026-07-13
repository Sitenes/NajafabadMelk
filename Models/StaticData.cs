namespace WebSite.Models;

public class StaticData
{
    public string Id { get; set; }
    public string? StringContentFa { get; set; }
    public string? StringContentEn { get; set; }
    public string? StringContentAr { get; set; }
    public int? BestCountOfNumber { get; set; }
    public string? ImageAdress { get; set; }
    public string Name { get; set; }
    public int GroupId { get; set; }
    public StaticDataGroup Group { get; set; }
}

public static class StaticDataExtensions
{
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
