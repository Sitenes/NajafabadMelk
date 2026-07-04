namespace WebSite.Models;

// مدل بازدید ملک
public class PropertyVisit
{
    public long Id { get; set; }

    public int DemandCode { get; set; }

    public string ApplicantName { get; set; }

    public string Mobile { get; set; }

    public string Time { get; set; }

    public string Date { get; set; }

    public string AgencyName { get; set; }

    public string MatchPercentage { get; set; }

    public string Description { get; set; }

    public string PropertyId { get; set; }

    public string PropertyCode { get; set; }
}