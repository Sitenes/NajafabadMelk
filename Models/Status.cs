using System.ComponentModel.DataAnnotations; // برای Data Annotations

// مدل وضعیت (Status)
public class Status
{
    public int Id { get; set; } // کلید اصلی

    [Required]
    public string Name { get; set; } // نام وضعیت

    public int Value { get; set; } // ارزش

    public int Group { get; set; } // گروه
}
