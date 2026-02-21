namespace Yuksi.Domain;

public partial class VehicleCapacityOption
{
    public Guid Id { get; set; }

    public Guid VehicleProductId { get; set; }

    public decimal MinWeight { get; set; }

    public decimal MaxWeight { get; set; }

    public string Label { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }
}
