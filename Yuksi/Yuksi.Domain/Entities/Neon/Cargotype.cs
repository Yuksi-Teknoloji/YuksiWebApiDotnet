using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class Cargotype
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? CreatedAt { get; set; }
}
