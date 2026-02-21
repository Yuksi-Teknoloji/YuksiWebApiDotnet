using Yuksi.Domain.Enums;

namespace Yuksi.Domain;

public sealed class Document
{
    public Guid Id { get; set; }
    public Guid? DriverId { get; set; }
    public DocType DocType { get; set; }
    public string? FileUrl { get; set; }
    public DateTime? UploadedAt { get; set; }
}
