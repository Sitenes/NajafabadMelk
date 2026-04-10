using System.ComponentModel.DataAnnotations; // برای Data Annotations

// مدل طبقه
public class HomeViewModel
{
    public int advertisementsCount { get; set; }
    public List<Advertisement> advertisements{ get; set; }
    public List<StaticData> staticDatas{ get; set; }
}
