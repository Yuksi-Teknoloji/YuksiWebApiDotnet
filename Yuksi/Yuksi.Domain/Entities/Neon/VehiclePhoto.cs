using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class VehiclePhoto
{
    public Guid Id { get; set; }

    public Guid VehicleId { get; set; }

    public Guid FileId { get; set; }

    public int OrderIndex { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual File File { get; set; } = null!;

    public virtual Vehicle Vehicle { get; set; } = null!;
}
