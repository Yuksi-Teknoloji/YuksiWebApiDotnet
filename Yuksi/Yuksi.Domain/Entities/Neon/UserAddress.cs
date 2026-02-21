namespace Yuksi.Domain;

public partial class UserAddress
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public string Title { get; set; } = null!;

    public string City { get; set; } = null!;

    public string District { get; set; } = null!;

    public string Mahalle { get; set; } = null!;

    public string Sokak { get; set; } = null!;

    public string Bina { get; set; } = null!;

    public string? Kat { get; set; }

    public string DaireNo { get; set; } = null!;

    public decimal Latitude { get; set; }

    public decimal Longitude { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual User User { get; set; } = null!;
}
