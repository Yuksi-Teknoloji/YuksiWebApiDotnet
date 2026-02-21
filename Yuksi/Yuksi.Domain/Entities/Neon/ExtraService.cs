using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class ExtraService
{
    public Guid Id { get; set; }

    public string CarrierType { get; set; } = null!;

    public string ServiceName { get; set; } = null!;

    public decimal Price { get; set; }

    public DateTime? CreatedAt { get; set; }
}
