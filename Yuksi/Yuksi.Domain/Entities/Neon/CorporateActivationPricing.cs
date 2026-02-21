namespace Yuksi.Domain;

public partial class CorporateActivationPricing
{
    public Guid Id { get; set; }

    public decimal GrossPrice { get; set; }

    public decimal VatPercentage { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
