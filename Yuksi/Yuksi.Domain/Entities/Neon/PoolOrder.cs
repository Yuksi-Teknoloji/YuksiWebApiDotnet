using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class PoolOrder
{
    public Guid OrderId { get; set; }

    public string? Message { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Order Order { get; set; } = null!;
}
