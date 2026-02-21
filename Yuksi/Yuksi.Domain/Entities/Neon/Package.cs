using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class Package
{
    public Guid Id { get; set; }

    public string Carrier { get; set; } = null!;

    public int Days { get; set; }

    public decimal Price { get; set; }

    public DateTime? CreatedAt { get; set; }
}
