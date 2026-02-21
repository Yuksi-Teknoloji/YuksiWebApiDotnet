using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class Document
{
    public Guid Id { get; set; }

    public Guid? DriverId { get; set; }

    public string? FileUrl { get; set; }

    public DateTime? UploadedAt { get; set; }
}
