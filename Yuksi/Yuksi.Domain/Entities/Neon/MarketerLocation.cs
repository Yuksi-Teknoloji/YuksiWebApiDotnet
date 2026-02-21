using Yuksİ.Domain;

namespace Yuksi.Domain;

public partial class MarketerLocation
{
    public int Id { get; set; }

    public Guid MarketerId { get; set; }

    public decimal Latitude { get; set; }

    public decimal Longitude { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual MarketerUser Marketer { get; set; } = null!;
}
