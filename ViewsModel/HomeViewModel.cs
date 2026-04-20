using System.ComponentModel.DataAnnotations; // برای Data Annotations
public class HomeViewModel
{
    public int advertisementsCount { get; set; }
    public List<Advertisement> advertisements { get; set; } = new List<Advertisement>();
    public List<StaticData> staticDatas { get; set; } = new List<StaticData>();
    public List<Agent> agents { get; set; } = new List<Agent>();
    public List<Article> articles { get; set; } = new List<Article>();
}

public class aboutViewModel
{
    public List<StaticData> staticDatas { get; set; } = new List<StaticData>();
}

public class agentViewModel
{
    public List<StaticData> staticDatas { get; set; } = new List<StaticData>();
    public List<Agent> agents { get; set; } = new List<Agent>();
}

public class blogViewModel
{
    public List<StaticData> staticDatas { get; set; } = new List<StaticData>();
    public List<Article> articles { get; set; } = new List<Article>();
    public int CurrentPage { get; set; } = 1;
    public int PageSize { get; set; } = 8;
    public int TotalCount { get; set; }
    public int TotalPages => PageSize <= 0 ? 0 : (int)Math.Ceiling((double)TotalCount / PageSize);
}

public class blogSingleViewModel
{
    public List<StaticData> staticDatas { get; set; } = new List<StaticData>();
    public Article? article { get; set; }
    public List<Article> recentArticles { get; set; } = new List<Article>();
}

public class contactViewModel
{
    public List<StaticData> staticDatas { get; set; } = new List<StaticData>();
}

public class propertiesViewModel
{
    public List<StaticData> staticDatas { get; set; } = new List<StaticData>();
    public List<Advertisement> advertisements { get; set; } = new List<Advertisement>();
    public int CurrentPage { get; set; } = 1;
    public int PageSize { get; set; } = 9;
    public int TotalCount { get; set; }
    public int TotalPages => PageSize <= 0 ? 0 : (int)Math.Ceiling((double)TotalCount / PageSize);
}

public class propertiesSingleViewModel
{
    public List<StaticData> staticDatas { get; set; } = new List<StaticData>();
    public Advertisement? advertisement { get; set; }
}

public class servicesViewModel
{
    public List<StaticData> staticDatas { get; set; } = new List<StaticData>();
}