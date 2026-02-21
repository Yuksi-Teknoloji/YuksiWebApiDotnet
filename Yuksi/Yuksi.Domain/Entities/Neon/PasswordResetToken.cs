namespace Yuksi.Domain;

public partial class PasswordResetToken
{
    public Guid Id { get; set; }

    public string Email { get; set; } = null!;

    public string VerificationCode { get; set; } = null!;

    public string UserType { get; set; } = null!;

    public DateTime ExpiresAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UsedAt { get; set; }

    public string? IpAddress { get; set; }
}
