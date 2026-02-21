using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class Driver
{
    public Guid Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public int? TotalDeliveries { get; set; }

    public decimal? AverageRating { get; set; }

    public int? TotalRatings { get; set; }

    public bool? IsActive { get; set; }

    public bool? Deleted { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? Username { get; set; }

    public string? CustomerServiceReference { get; set; }

    public long? CityId { get; set; }

    public string? FullAddress { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyAddress { get; set; }

    public string? CompanyNumber { get; set; }

    public Guid? ProfilePhotoFileId { get; set; }

    public string? Iban { get; set; }

    public string? About { get; set; }

    public string? MapPreference { get; set; }

    public virtual ICollection<CarrierPackageSubscription> CarrierPackageSubscriptions { get; set; } = new List<CarrierPackageSubscription>();

    public virtual ICollection<CarrierSubscriptionRequest> CarrierSubscriptionRequests { get; set; } = new List<CarrierSubscriptionRequest>();

    public virtual ICollection<CourierBreakSession> CourierBreakSessions { get; set; } = new List<CourierBreakSession>();

    public virtual ICollection<CourierBreak> CourierBreaks { get; set; } = new List<CourierBreak>();

    public virtual ICollection<CourierOrdersLog> CourierOrdersLogs { get; set; } = new List<CourierOrdersLog>();

    public virtual ICollection<CourierPackageSubscription> CourierPackageSubscriptions { get; set; } = new List<CourierPackageSubscription>();

    public virtual ICollection<CourierRating> CourierRatings { get; set; } = new List<CourierRating>();

    public virtual ICollection<CourierSubscriptionRequest> CourierSubscriptionRequests { get; set; } = new List<CourierSubscriptionRequest>();

    public virtual DriverActive? DriverActive { get; set; }

    public virtual ICollection<DriverPresenceEvent> DriverPresenceEvents { get; set; } = new List<DriverPresenceEvent>();

    public virtual DriverWorkTime? DriverWorkTime { get; set; }

    public virtual GpsTable? GpsTable { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual File? ProfilePhotoFile { get; set; }

    public virtual ICollection<RestaurantCourier> RestaurantCouriers { get; set; } = new List<RestaurantCourier>();

    public virtual ICollection<SupportTicketsCourier> SupportTicketsCouriers { get; set; } = new List<SupportTicketsCourier>();

    public virtual ICollection<UserJobOffer> UserJobOffers { get; set; } = new List<UserJobOffer>();

    public virtual ICollection<UserJob> UserJobs { get; set; } = new List<UserJob>();

    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}
