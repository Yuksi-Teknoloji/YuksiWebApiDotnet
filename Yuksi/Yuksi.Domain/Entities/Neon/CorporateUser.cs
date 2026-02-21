using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class CorporateUser
{
    public Guid Id { get; set; }

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string? Phone { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public bool? IsActive { get; set; }

    public bool? Deleted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public decimal? CommissionRate { get; set; }

    public long? CountryId { get; set; }

    public long? StateId { get; set; }

    public long? CityId { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? CommissionDescription { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public string? TaxOffice { get; set; }

    public string? TaxNumber { get; set; }

    public string? Iban { get; set; }

    public string? Resume { get; set; }

    public int? OnboardingStatus { get; set; }

    public bool? SetupFeePaid { get; set; }

    public DateTime? SetupFeePaidAt { get; set; }

    public DateTime? SetupFeeApprovedAt { get; set; }

    public Guid? SetupFeeApprovedBy { get; set; }

    public string? SetupFeeRejectionReason { get; set; }

    public string Status { get; set; } = null!;

    public List<int>? Access { get; set; }

    public string? Platform { get; set; }

    public string? CompanyName { get; set; }

    public string? Vkn { get; set; }

    public string? City { get; set; }

    public string? District { get; set; }

    public string? Neighborhood { get; set; }

    public string? Street { get; set; }

    public string? BuildingNumber { get; set; }

    public string? ApartmentNumber { get; set; }

    public string? Floor { get; set; }

    public string? PostalCode { get; set; }

    public virtual ICollection<AdminJob> AdminJobs { get; set; } = new List<AdminJob>();

    public virtual BusinessCompany? BusinessCompany { get; set; }

    public virtual ICollection<KurumsalPackageSubscription> KurumsalPackageSubscriptions { get; set; } = new List<KurumsalPackageSubscription>();

    public virtual ICollection<KurumsalSubscriptionRequest> KurumsalSubscriptionRequests { get; set; } = new List<KurumsalSubscriptionRequest>();

    public virtual ICollection<OnboardingCorporate> OnboardingCorporates { get; set; } = new List<OnboardingCorporate>();
}
