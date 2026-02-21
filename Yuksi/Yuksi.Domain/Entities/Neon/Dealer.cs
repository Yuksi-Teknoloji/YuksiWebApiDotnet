namespace Yuksi.Domain;

public partial class Dealer
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string AccountType { get; set; } = null!;

    public int CountryId { get; set; }

    public int CityId { get; set; }

    public int StateId { get; set; }

    public string? TaxOffice { get; set; }

    public string? Phone { get; set; }

    public string? TaxNumber { get; set; }

    public string? Iban { get; set; }

    public string? Resume { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public decimal? CommissionRate { get; set; }

    public string? CommissionDescription { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public bool? Deleted { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<AdminJob> AdminJobs { get; set; } = new List<AdminJob>();

    public virtual ICollection<DealerCompany> DealerCompanies { get; set; } = new List<DealerCompany>();

    public virtual ICollection<DealerCompany1> DealerCompany1s { get; set; } = new List<DealerCompany1>();

    public virtual ICollection<DealerRestaurant> DealerRestaurants { get; set; } = new List<DealerRestaurant>();
}
