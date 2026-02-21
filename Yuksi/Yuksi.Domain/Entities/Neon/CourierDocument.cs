using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class CourierDocument
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public Guid FileId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual File File { get; set; } = null!;
}
