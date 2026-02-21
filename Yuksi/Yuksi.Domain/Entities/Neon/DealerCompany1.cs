using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class DealerCompany1
{
    public Guid Id { get; set; }

    public Guid DealerId { get; set; }

    public Guid CompanyId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual Dealer Dealer { get; set; } = null!;
}
