namespace Yuksi.Domain;

public partial class CityPrice
{
    public Guid Id { get; set; }

    public string RouteName { get; set; } = null!;

    public int CountryId { get; set; }

    public int StateId { get; set; }

    public int? CityId { get; set; }

    public decimal CourierPrice { get; set; }

    public decimal MinivanPrice { get; set; }

    public decimal PanelvanPrice { get; set; }

    public decimal KamyonetPrice { get; set; }

    public decimal KamyonPrice { get; set; }

    public DateTime? CreatedAt { get; set; }
}
