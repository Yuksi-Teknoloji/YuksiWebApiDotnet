namespace Yuksi.Domain;

public partial class GeneralSetting
{
    public Guid Id { get; set; }

    public string AppName { get; set; } = null!;

    public string AppTitle { get; set; } = null!;

    public string Keywords { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Whatsapp { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string MapEmbedCode { get; set; } = null!;

    public string? LogoPath { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? DailyBreakMinutes { get; set; }
}
