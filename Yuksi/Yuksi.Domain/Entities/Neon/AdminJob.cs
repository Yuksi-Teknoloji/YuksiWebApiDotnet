namespace Yuksi.Infrastructure;

public partial class AdminJob
{
    public Guid Id { get; set; }

    public string DeliveryType { get; set; } = null!;

    public string CarrierType { get; set; } = null!;

    public string VehicleType { get; set; } = null!;

    public string PickupAddress { get; set; } = null!;

    public string PickupCoordinates { get; set; } = null!;

    public string DropoffAddress { get; set; } = null!;

    public string DropoffCoordinates { get; set; } = null!;

    public string? SpecialNotes { get; set; }

    public string? CampaignCode { get; set; }

    public string? ExtraServices { get; set; }

    public decimal? ExtraServicesTotal { get; set; }

    public decimal TotalPrice { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public string? ImageFileIds { get; set; }

    public bool? CreatedByAdmin { get; set; }

    public DateTime? CreatedAt { get; set; }

    public Guid? RestaurantId { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public TimeOnly? DeliveryTime { get; set; }

    public Guid? DealerId { get; set; }

    public Guid? CorporateId { get; set; }

    public Guid? VehicleProductId { get; set; }

    public Guid? CompanyId { get; set; }

    public virtual Company? Company { get; set; }

    public virtual CorporateUser? Corporate { get; set; }

    public virtual Dealer? Dealer { get; set; }

    public virtual Restaurant? Restaurant { get; set; }

    public virtual VehicleType VehicleTypeNavigation { get; set; } = null!;
}
