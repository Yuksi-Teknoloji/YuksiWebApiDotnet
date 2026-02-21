using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class File
{
    public Guid Id { get; set; }

    public Guid? UserId { get; set; }

    public string? ImageUrl { get; set; }

    public int? Size { get; set; }

    public string? MimeType { get; set; }

    public string? Filename { get; set; }

    public string? Key { get; set; }

    public DateTime? UploadedAt { get; set; }

    public DateTime? DelatedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<CarrierType> CarrierTypes { get; set; } = new List<CarrierType>();

    public virtual ICollection<CourierDocument> CourierDocuments { get; set; } = new List<CourierDocument>();

    public virtual ICollection<Driver> Drivers { get; set; } = new List<Driver>();

    public virtual ICollection<OnboardingCorporate> OnboardingCorporates { get; set; } = new List<OnboardingCorporate>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();

    public virtual ICollection<VehiclePhoto> VehiclePhotos { get; set; } = new List<VehiclePhoto>();
}
