using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class CompanyPackage
{
    public Guid Id { get; set; }

    public int CarrierKm { get; set; }

    public int RequestedKm { get; set; }

    public decimal Price { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
