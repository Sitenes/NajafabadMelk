using System.ComponentModel.DataAnnotations; // برای Data Annotations
public class HomeViewModel
{
    public int advertisementsCount { get; set; }
    public List<Advertisement> advertisements { get; set; }
    public List<StaticData> staticDatas { get; set; }
}

public class aboutViewModel
{
    public List<StaticData> staticDatas { get; set; }
}

public class agentViewModel
{
    public List<StaticData> staticDatas { get; set; }
}

public class blogViewModel
{
    public List<StaticData> staticDatas { get; set; }
}

public class blogSingleViewModel
{
    public List<StaticData> staticDatas { get; set; }
}

public class contactViewModel
{
    public List<StaticData> staticDatas { get; set; }
}

public class propertiesViewModel
{
    public List<StaticData> staticDatas { get; set; }
}

public class propertiesSingleViewModel
{
    public List<StaticData> staticDatas { get; set; }
}

public class servicesViewModel
{
    public List<StaticData> staticDatas { get; set; }
}