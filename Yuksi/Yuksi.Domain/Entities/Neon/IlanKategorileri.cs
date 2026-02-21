namespace Yuksi.Domain;

public partial class IlanKategorileri
{
    public Guid Id { get; set; }

    public Guid IlanId { get; set; }

    public Guid AnaKategoriId { get; set; }

    public Guid? AltKategoriId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual TicarimAltKategoriler? AltKategori { get; set; }

    public virtual TicarimAnaKategoriler AnaKategori { get; set; } = null!;

    public virtual VehicleListing Ilan { get; set; } = null!;
}
