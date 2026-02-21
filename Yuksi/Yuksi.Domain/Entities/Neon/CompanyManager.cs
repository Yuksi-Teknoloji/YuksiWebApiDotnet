namespace Yuksi.Domain;

public partial class CompanyManager
{
    public Guid Id { get; set; }

    public Guid CompanyId { get; set; }

    public string NameSurname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public bool? Deleted { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? PasswordHash { get; set; }

    public virtual Company Company { get; set; } = null!;
}
