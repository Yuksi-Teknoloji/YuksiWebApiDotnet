using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class UserJob
{
    public Guid Id { get; set; }

    public string DeliveryType { get; set; } = null!;

    public string CarrierType { get; set; } = null!;

    public string? VehicleType { get; set; }

    public Guid? VehicleProductId { get; set; }

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

    public Guid UserId { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public TimeOnly? DeliveryTime { get; set; }

    public DateTime? CreatedAt { get; set; }

    public Guid? AssignedCourierId { get; set; }

    public string? JobStatus { get; set; }

    public DateTime? AssignedAt { get; set; }

    public bool? Deleted { get; set; }

    public int? CurrentRadiusTier { get; set; }

    public DateTime? LastOfferSentAt { get; set; }

    public virtual Driver? AssignedCourier { get; set; }

    public virtual User User { get; set; } = null!;

    public virtual ICollection<UserJobOffer> UserJobOffers { get; set; } = new List<UserJobOffer>();

    public virtual VehicleProduct? VehicleProduct { get; set; }

    public virtual VehicleType? VehicleTypeNavigation { get; set; }
}
