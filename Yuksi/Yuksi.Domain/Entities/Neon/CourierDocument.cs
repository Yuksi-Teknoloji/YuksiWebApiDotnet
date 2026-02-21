using Yuksi.Domain.Enums;

namespace Yuksi.Domain;

public sealed class CourierDocument
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid FileId { get; set; }
    public CourierDocType DocType { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public CourierDocumentStatus CourierDocumentStatus { get; set; }
    public File File { get; set; } = null!;
}
