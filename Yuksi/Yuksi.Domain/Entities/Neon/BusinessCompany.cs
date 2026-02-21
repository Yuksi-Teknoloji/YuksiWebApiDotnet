namespace Yuksi.Domain;

public partial class BusinessCompany
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string Vkn { get; set; } = null!;

    public string TaxOffice { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual CorporateUser User { get; set; } = null!;
}
