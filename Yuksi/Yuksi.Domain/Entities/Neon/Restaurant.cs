using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class Restaurant
{
    public Guid Id { get; set; }

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public long? CountryId { get; set; }

    public string Name { get; set; } = null!;

    public string? ContactPerson { get; set; }

    public string? TaxNumber { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public long? StateId { get; set; }

    public long? CityId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public TimeOnly? OpeningHour { get; set; }

    public TimeOnly? ClosingHour { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public bool? Deleted { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<AdminJob> AdminJobs { get; set; } = new List<AdminJob>();

    public virtual ICollection<CourierRating> CourierRatings { get; set; } = new List<CourierRating>();

    public virtual ICollection<DealerRestaurant> DealerRestaurants { get; set; } = new List<DealerRestaurant>();

    public virtual ICollection<OrderWatcher> OrderWatchers { get; set; } = new List<OrderWatcher>();

    public virtual ICollection<RestaurantCourier> RestaurantCouriers { get; set; } = new List<RestaurantCourier>();

    public virtual ICollection<RestaurantMenu> RestaurantMenus { get; set; } = new List<RestaurantMenu>();

    public virtual RestaurantPackagePrice? RestaurantPackagePrice { get; set; }

    public virtual ICollection<SupportTicket> SupportTickets { get; set; } = new List<SupportTicket>();
}
