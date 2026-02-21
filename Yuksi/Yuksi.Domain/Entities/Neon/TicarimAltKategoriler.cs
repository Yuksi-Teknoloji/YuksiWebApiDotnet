using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class TicarimAltKategoriler
{
    public Guid Id { get; set; }

    public Guid AnaKategoriId { get; set; }

    public string KategoriAdi { get; set; } = null!;

    public string? Aciklama { get; set; }

    public int? SiraNo { get; set; }

    public bool? Aktif { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual TicarimAnaKategoriler AnaKategori { get; set; } = null!;

    public virtual ICollection<IlanKategorileri> IlanKategorileris { get; set; } = new List<IlanKategorileri>();
}
