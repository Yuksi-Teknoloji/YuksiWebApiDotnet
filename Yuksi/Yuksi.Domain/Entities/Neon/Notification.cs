using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class Notification
{
    public Guid Id { get; set; }

    public string TargetType { get; set; } = null!;

    public Guid TargetId { get; set; }

    public string Title { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string? LogoUri { get; set; }

    public bool Clickable { get; set; }

    public Guid? RelatedId { get; set; }

    public string? RelatedType { get; set; }

    public bool Delivered { get; set; }

    public bool Seen { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? DeliveredAt { get; set; }

    public DateTime? SeenAt { get; set; }
}
