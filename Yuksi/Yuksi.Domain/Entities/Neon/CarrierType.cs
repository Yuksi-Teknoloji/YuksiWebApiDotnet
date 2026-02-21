namespace Yuksi.Domain;

public partial class CarrierType
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public int StartKm { get; set; }

    public decimal StartPrice { get; set; }

    public decimal KmPrice { get; set; }

    public Guid? ImageFileId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual File? ImageFile { get; set; }
}
