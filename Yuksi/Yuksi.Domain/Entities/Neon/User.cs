namespace Yuksi.Domain;

public partial class User
{
    public Guid Id { get; set; }

    public Guid RoleId { get; set; }

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string? Phone { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public bool? IsActive { get; set; }

    public bool? Deleted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public Guid? ProfilePhotoId { get; set; }

    public string? MapPreference { get; set; }

    public virtual File? ProfilePhoto { get; set; }

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<UserAddress> UserAddresses { get; set; } = new List<UserAddress>();

    public virtual ICollection<UserJob> UserJobs { get; set; } = new List<UserJob>();
}
