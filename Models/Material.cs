using System.ComponentModel.DataAnnotations; // برای Data Annotations

public class Material
{
    public int Id { get; set; }
    public string Content { get; set; }
    public string Name { get; set; }
    public List<Floor> Floors { get; set;} = new List<Floor>();
}