using System.ComponentModel.DataAnnotations; // برای Data Annotations

// مدل معامله
public class Deal
{
    public int Id { get; set; } // کلید اصلی

    [Required]
    public string DealType { get; set; } // نوع معامله (مثلا: فروش، اجاره)

    public decimal? DownPayment { get; set; } // پیش پرداخت (Nullable, استفاده از decimal برای پول)

    public decimal? MonthlyPayment { get; set; } // پرداخت ماهانه (Nullable)

    public decimal TotalPrice { get; set; } // قیمت کل

    public bool IsExchangeable { get; set; } // قابلیت معاوضه (دارد – ندارد)

     public int AdvertisementId { get; set; }
     public Advertisement Advertisement { get; set; }
}
