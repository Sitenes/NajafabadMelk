using System.ComponentModel.DataAnnotations; // برای Data Annotations

// مدل معامله
public class Deal
{
    public int Id { get; set; }
    public decimal? DownPayment { get; set; }
    public decimal? MonthlyPayment { get; set; }
    public decimal TotalPrice { get; set; }
    public bool IsExchangeable { get; set; }
    
    //Relation ----------------------
    public int DealTypeId { get; set; }
    public Status DealType { get; set; }
}