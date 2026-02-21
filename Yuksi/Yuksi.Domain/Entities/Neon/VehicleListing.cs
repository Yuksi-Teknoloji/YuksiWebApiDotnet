namespace Yuksi.Infrastructure;

public partial class VehicleListing
{
    public Guid Id { get; set; }

    public Guid OwnerId { get; set; }

    public string OwnerType { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Brand { get; set; } = null!;

    public string Model { get; set; } = null!;

    public int Year { get; set; }

    public int Km { get; set; }

    public int EngineSize { get; set; }

    public string FuelType { get; set; } = null!;

    public string Transmission { get; set; } = null!;

    public string BodyType { get; set; } = null!;

    public string Color { get; set; } = null!;

    public string Condition { get; set; } = null!;

    public bool? HeavyDamageRecorded { get; set; }

    public string? Source { get; set; }

    public string? Plate { get; set; }

    public string? Nationality { get; set; }

    public decimal Price { get; set; }

    public string Location { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string? Status { get; set; }

    public string? AdminNotes { get; set; }

    public bool? IsSponsored { get; set; }

    public string? SponsorMeta { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<IlanKategorileri> IlanKategorileris { get; set; } = new List<IlanKategorileri>();

    public virtual ICollection<VehicleListingImage> VehicleListingImages { get; set; } = new List<VehicleListingImage>();
}
