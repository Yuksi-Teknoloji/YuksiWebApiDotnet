using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class Banner
{
    public Guid Id { get; set; }

    public string? Title { get; set; }

    public string? ImageUrl { get; set; }

    public int? Priority { get; set; }

    public bool? Active { get; set; }
}
