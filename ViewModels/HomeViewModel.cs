using System.ComponentModel.DataAnnotations; // برای Data Annotations
using WebSite.Models;

namespace WebSite.ViewModels;

public class HomeViewModel
{
    public int propertyCount { get; set; }
    public List<Property> properties { get; set; } = new List<Property>();
    public List<StaticData> staticDatas { get; set; } = new List<StaticData>();
    public List<User> agents { get; set; } = new List<User>();
    public List<Property> articles { get; set; } = new List<Property>(); // Using Property as placeholder for now
}

public class aboutViewModel
{
    public List<StaticData> staticDatas { get; set; } = new List<StaticData>();
}

public class agentViewModel
{
    public List<User> agents { get; set; } = new List<User>();
    public List<StaticData> staticDatas { get; set; } = new List<StaticData>();
}

public class blogViewModel
{
    public int CurrentPage { get; set; } = 1;
    public int PageSize { get; set; } = 8;
    public int TotalCount { get; set; }
    public int TotalPages => PageSize <= 0 ? 0 : (int)Math.Ceiling((double)TotalCount / PageSize);
    public List<StaticData> staticDatas { get; set; } = new List<StaticData>();
    public List<Property> articles { get; set; } = new List<Property>();
}

public class blogSingleViewModel
{
    public List<StaticData> staticDatas { get; set; } = new List<StaticData>();
    public Property? article { get; set; }
    public List<Property> recentArticles { get; set; } = new List<Property>();
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

public class propertiesViewModel
{
    public List<Property> properties { get; set; } = new List<Property>();
    public int CurrentPage { get; set; } = 1;
    public int PageSize { get; set; } = 9;
    public int TotalCount { get; set; }
    public int TotalPages => PageSize <= 0 ? 0 : (int)Math.Ceiling((double)TotalCount / PageSize);
    public List<StaticData> staticDatas { get; set; } = new List<StaticData>();
}