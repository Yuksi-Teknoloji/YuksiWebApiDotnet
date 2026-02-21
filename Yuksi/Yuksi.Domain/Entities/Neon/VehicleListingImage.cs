namespace Yuksi.Domain;

public partial class VehicleListingImage
{
    public Guid Id { get; set; }

    public Guid ListingId { get; set; }

    public Guid FileId { get; set; }

    public int? OrderIndex { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual VehicleListing Listing { get; set; } = null!;
}
