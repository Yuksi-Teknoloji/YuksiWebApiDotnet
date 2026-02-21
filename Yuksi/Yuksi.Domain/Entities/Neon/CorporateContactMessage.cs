namespace Yuksi.Domain;

public partial class CorporateContactMessage
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? BusinessName { get; set; }

    public string Email { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Subject { get; set; }

    public string? Message { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? City { get; set; }

    public string? Status { get; set; }
}
