namespace Yuksİ.Domain;

public partial class Picture
{
    public Guid Id { get; set; }

    public string UserType { get; set; } = null!;

    public Guid UserId { get; set; }

    public string Url { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }
}
