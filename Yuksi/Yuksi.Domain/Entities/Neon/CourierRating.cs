using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class CourierRating
{
    public Guid Id { get; set; }

    public Guid? CourierId { get; set; }

    public Guid? RestaurantId { get; set; }

    public Guid? OrderId { get; set; }

    public int Rating { get; set; }

    public string? Comment { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Driver? Courier { get; set; }

    public virtual Order? Order { get; set; }

    public virtual Restaurant? Restaurant { get; set; }
}
