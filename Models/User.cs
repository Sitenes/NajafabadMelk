namespace WebSite.Models;

public class User
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedByUserId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public bool? IsActive { get; set; }
    public string? MobileNumber { get; set; }
}

public static class UserExtensions
{
    public static string LocalizedName(this User? user, string lang)
    {
        if (user == null) return string.Empty;
        return $"{user.FirstName} {user.LastName}";
    }

    public static string LocalizedExpert(this User? user, string lang)
    {
        return "Real Estate Agent";
    }

    public static string ImageAddress(this User? user)
    {
        return "person_1.jpg";
    }
}