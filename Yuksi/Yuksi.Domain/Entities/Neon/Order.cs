using Yuksi.Domain.Enums;

namespace Yuksi.Domain;

public sealed class Order
{
    public Guid Id { get; set; }
    public Guid RestaurantId { get; set; }
    public string Code { get; set; } = null!;
    public string Customer { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string DeliveryAddress { get; set; } = null!;
    public DeliveryType Type { get; set; }
    public OrderStatus Status { get; set; }
    public decimal Amount { get; set; }
    public string? CarrierType { get; set; }
    public string? VehicleType { get; set; }
    public string? CargoType { get; set; }
    public string? SpecialRequests { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public Guid? CourierId { get; set; }
    public decimal? PickupLat { get; set; }
    public decimal? PickupLng { get; set; }
    public decimal? DropoffLat { get; set; }
    public decimal? DropoffLng { get; set; }
    public decimal? PackageConsumed { get; set; }
    public string? TriggerSource { get; set; }
    public Driver? Courier { get; set; }
    public ICollection<CourierOrdersLog> CourierOrdersLogs { get; set; } = new List<CourierOrdersLog>();
    public ICollection<CourierRating> CourierRatings { get; set; } = new List<CourierRating>();
    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    public OrderWatcher? OrderWatcher { get; set; }
    public VehicleType? VehicleTypeNavigation { get; set; }
}
