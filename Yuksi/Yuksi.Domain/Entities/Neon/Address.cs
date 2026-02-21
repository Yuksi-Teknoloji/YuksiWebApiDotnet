namespace Yuksi.Domain;

public sealed class Address
{
    public Guid Id { get; set; }
    public string EntityType { get; set; } = null!;
    public Guid EntityId { get; set; }
    public string AddressType { get; set; } = null!;
    public string City { get; set; } = null!;
    public string District { get; set; } = null!;
    public string? Neighborhood { get; set; }
    public string? Street { get; set; }
    public string? BuildingNumber { get; set; }
    public string? ApartmentNumber { get; set; }
    public string? Floor { get; set; }
    public string? PostalCode { get; set; }
    public string? FullAddress { get; set; }
    public string? AddressTitle { get; set; }
    public string? ContactName { get; set; }
    public string? ContactPhone { get; set; }
    public decimal? Latitude { get; set; }
    public decimal? Longitude { get; set; }
    public bool? IsActive { get; set; }
    public bool? IsDefault { get; set; }
    public bool? Deleted { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
