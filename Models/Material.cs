using System.ComponentModel.DataAnnotations; // برای Data Annotations

public class Material
{
    public int Id { get; set; }
    public string ContentFa { get; set; }
    public string ContentEn { get; set; }
    public string ContentAr { get; set; }
    public string Name { get; set; }
    public List<Floor> Floors { get; set; } = new List<Floor>();
}