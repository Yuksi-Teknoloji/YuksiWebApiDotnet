namespace Yuksi.Domain;

public partial class Document
{
    public Guid Id { get; set; }

    public Guid? DriverId { get; set; }

    public string? FileUrl { get; set; }

    public DateTime? UploadedAt { get; set; }
}
