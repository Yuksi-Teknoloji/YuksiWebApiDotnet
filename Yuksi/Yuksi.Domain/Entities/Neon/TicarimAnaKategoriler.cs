namespace Yuksi.Domain;

public partial class TicarimAnaKategoriler
{
    public Guid Id { get; set; }

    public string KategoriAdi { get; set; } = null!;

    public string? Aciklama { get; set; }

    public int? SiraNo { get; set; }

    public bool? Aktif { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<IlanKategorileri> IlanKategorileris { get; set; } = new List<IlanKategorileri>();

    public virtual ICollection<TicarimAltKategoriler> TicarimAltKategorilers { get; set; } = new List<TicarimAltKategoriler>();
}
