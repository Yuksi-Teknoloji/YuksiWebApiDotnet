using Yuksi.Domain.Enums;

namespace Yuksi.Domain;

public sealed class Subsection
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public ContentType ContentType { get; set; }
    public bool? ShowInMenu { get; set; }
    public bool? ShowInFooter { get; set; }
    public string Content { get; set; } = null!;
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
