namespace Yuksi.Infrastructure;

public partial class VehicleType
{
    public Guid Id { get; set; }

    public string Type { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string TypeCode { get; set; } = null!;

    public virtual ICollection<AdminJob> AdminJobs { get; set; } = new List<AdminJob>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<UserJob> UserJobs { get; set; } = new List<UserJob>();

    public virtual ICollection<VehicleProduct> VehicleProducts { get; set; } = new List<VehicleProduct>();

    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}
