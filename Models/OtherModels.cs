namespace WebSite.Models;

public class Supplier
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedByUserId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? NationalCode { get; set; }
    public string? Phone1Number { get; set; }
    public string? Phone2Number { get; set; }
    public string? MobileNumber { get; set; }
    public string? Referral { get; set; }
}

public class Tag
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedByUserId { get; set; }
    public string? Title { get; set; }
}