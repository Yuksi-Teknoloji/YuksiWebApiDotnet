namespace Yuksi.Domain;

public partial class Company
{
    public Guid Id { get; set; }

    public string CompanyTrackingNo { get; set; } = null!;

    public int AssignedKilometers { get; set; }

    public int ConsumedKilometers { get; set; }

    public decimal SpecialCommissionRate { get; set; }

    public bool IsVisible { get; set; }

    public bool CanReceivePayments { get; set; }

    public long CityId { get; set; }

    public long StateId { get; set; }

    public string Location { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string CompanyPhone { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public bool? Deleted { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<AdminJob> AdminJobs { get; set; } = new List<AdminJob>();

    public virtual ICollection<CompanyManager> CompanyManagers { get; set; } = new List<CompanyManager>();

    public virtual DealerCompany? DealerCompany { get; set; }

    public virtual ICollection<DealerCompany1> DealerCompany1s { get; set; } = new List<DealerCompany1>();
}
