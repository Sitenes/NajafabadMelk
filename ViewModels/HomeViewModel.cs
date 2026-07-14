using System.ComponentModel.DataAnnotations; // برای Data Annotations
using WebSite.Models;

namespace WebSite.ViewModels;

public class HomeViewModel
{
    public int propertyCount { get; set; }
    public List<Property> properties { get; set; } = new List<Property>();
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
    public List<Agent> agents { get; set; } = new List<Agent>();
    public List<StaticData> staticDatas { get; set; } = new List<StaticData>();
}

public class blogViewModel
{
    public int CurrentPage { get; set; } = 1;
    public int PageSize { get; set; } = 8;
    public int TotalCount { get; set; }
    public int TotalPages => PageSize <= 0 ? 0 : (int)Math.Ceiling((double)TotalCount / PageSize);
    public List<StaticData> staticDatas { get; set; } = new List<StaticData>();
    public List<Article> articles { get; set; } = new List<Article>();
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

public class servicesViewModel
{
    public List<StaticData> staticDatas { get; set; } = new List<StaticData>();
}

public class propertiesSingleViewModel
{
    public Property? property { get; set; }
    public List<Property> properties { get; set; } = new List<Property>();
    public List<StaticData> staticDatas { get; set; } = new List<StaticData>();
}

public class PropertyCreateEditViewModel
{
    public Property Property { get; set; } = new();
    public List<Floor> Floors { get; set; } = new();
    public List<int> SelectedTagIds { get; set; } = new();
}


public class propertiesViewModel
{
    public List<Property> properties { get; set; } = new List<Property>();
    public int CurrentPage { get; set; } = 1;
    public int PageSize { get; set; } = 9;
    public int TotalCount { get; set; }
    public int TotalPages => PageSize <= 0 ? 0 : (int)Math.Ceiling((double)TotalCount / PageSize);
    public List<StaticData> staticDatas { get; set; } = new List<StaticData>();
}