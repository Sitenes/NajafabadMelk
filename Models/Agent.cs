public class Agent
{
    public int Id { get; set; }

    public string NameFa { get; set; } = string.Empty;
    public string NameEn { get; set; } = string.Empty;
    public string NameAr { get; set; } = string.Empty;
    public string ExpertFa { get; set; } = string.Empty;
    public string ExpertEn { get; set; } = string.Empty;
    public string ExpertAr { get; set; } = string.Empty;
    public string? Username { get; set; }
    public string? Password { get; set; }
    public string? Post { get; set; }
    public int? LastLoginDate { get; set; }
    public int? IsMaster { get; set; }
    public bool IsActive { get; set; }
    public string ImageAddress { get; set; } = string.Empty;
}

public static class AgentExtensions
{
    public static string LocalizedName(this Agent? agent, string lang)
    {
        if (agent == null) return string.Empty;

        return lang switch
        {
            "fa" => agent.NameFa ?? agent.NameEn ?? string.Empty,
            "ar" => agent.NameAr ?? agent.NameEn ?? string.Empty,
            _ => agent.NameEn ?? agent.NameFa ?? string.Empty
        };
    }

    public static string LocalizedExpert(this Agent? agent, string lang)
    {
        if (agent == null) return string.Empty;

        return lang switch
        {
            "fa" => agent.ExpertFa ?? agent.ExpertEn ?? string.Empty,
            "ar" => agent.ExpertAr ?? agent.ExpertEn ?? string.Empty,
            _ => agent.ExpertEn ?? agent.ExpertFa ?? string.Empty
        };
    }
}