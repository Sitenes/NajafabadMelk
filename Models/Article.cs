public class Article
{
    public int Id { get; set; }

    public string TitleFa { get; set; } = string.Empty;
    public string TitleEn { get; set; } = string.Empty;
    public string TitleAr { get; set; } = string.Empty;

    public string SummaryFa { get; set; } = string.Empty;
    public string SummaryEn { get; set; } = string.Empty;
    public string SummaryAr { get; set; } = string.Empty;

    public string ContentFa { get; set; } = string.Empty;
    public string ContentEn { get; set; } = string.Empty;
    public string ContentAr { get; set; } = string.Empty;

    public string AuthorName { get; set; } = string.Empty;
    public string ImageAddress { get; set; } = string.Empty;
    public DateTime PublishedAt { get; set; } = DateTime.UtcNow;
    public bool IsPublished { get; set; } = true;
}

public static class ArticleExtensions
{
    public static string LocalizedTitle(this Article? article, string lang)
    {
        if (article == null) return string.Empty;

        return lang switch
        {
            "fa" => article.TitleFa ?? article.TitleEn ?? string.Empty,
            "ar" => article.TitleAr ?? article.TitleEn ?? string.Empty,
            _ => article.TitleEn ?? article.TitleFa ?? string.Empty
        };
    }

    public static string LocalizedSummary(this Article? article, string lang)
    {
        if (article == null) return string.Empty;

        return lang switch
        {
            "fa" => article.SummaryFa ?? article.SummaryEn ?? string.Empty,
            "ar" => article.SummaryAr ?? article.SummaryEn ?? string.Empty,
            _ => article.SummaryEn ?? article.SummaryFa ?? string.Empty
        };
    }

    public static string LocalizedContent(this Article? article, string lang)
    {
        if (article == null) return string.Empty;

        return lang switch
        {
            "fa" => article.ContentFa ?? article.ContentEn ?? string.Empty,
            "ar" => article.ContentAr ?? article.ContentEn ?? string.Empty,
            _ => article.ContentEn ?? article.ContentFa ?? string.Empty
        };
    }
}