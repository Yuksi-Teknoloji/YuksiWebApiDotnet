namespace Yuksi.Domain;

public partial class BusinessPartner
{
    public Guid Id { get; set; }

    public string Title { get; set; } = null!;

    public string City { get; set; } = null!;

    public string District { get; set; } = null!;

    public string? ServiceArea { get; set; }

    public string? LogoImageUrl { get; set; }

    public DateOnly? PublishDate { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? Deleted { get; set; }

    public DateTime? DeletedAt { get; set; }
}
