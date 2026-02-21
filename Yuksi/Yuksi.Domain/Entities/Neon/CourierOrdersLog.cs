namespace Yuksi.Domain;

public partial class CourierOrdersLog
{
    public Guid Id { get; set; }

    public Guid? CourierId { get; set; }

    public Guid? OrderId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? TriggerSource { get; set; }

    public virtual Driver? Courier { get; set; }

    public virtual Order? Order { get; set; }
}
