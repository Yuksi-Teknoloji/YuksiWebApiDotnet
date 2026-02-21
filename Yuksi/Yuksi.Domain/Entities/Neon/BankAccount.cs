namespace Yuksi.Domain;

public partial class BankAccount
{
    public Guid Id { get; set; }

    public string BankName { get; set; } = null!;

    public string AccountHolder { get; set; } = null!;

    public string Iban { get; set; } = null!;

    public string? BranchName { get; set; }

    public string? AccountNumber { get; set; }

    public bool? IsActive { get; set; }

    public int? DisplayOrder { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
