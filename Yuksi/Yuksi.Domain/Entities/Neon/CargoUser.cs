using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class CargoUser
{
    public Guid Id { get; set; }

    public string UserType { get; set; } = null!;

    public Guid UserId { get; set; }

    public string RefreshToken { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? CargoPassword { get; set; }
}
