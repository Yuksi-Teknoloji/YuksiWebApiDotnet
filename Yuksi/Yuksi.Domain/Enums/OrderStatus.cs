using NpgsqlTypes;

namespace Yuksi.Domain.Enums;

public enum OrderStatus
{
    [PgName("kuryeye_istek_atildi")]
    KuryeyeIstemAtildi,
    [PgName("yolda")]
    Yolda,
    [PgName("siparis_havuza_atildi")]
    SiparisHavuzaAtildi,
    [PgName("konuma_geldim")]
    KonumaGeldim,
    [PgName("kurye_reddetti")]
    KuryeReddetti,
    [PgName("teslim_edildi")]
    TeslimEdildi,
    [PgName("kuryeye_verildi")]
    KuryeyeVerildi,
    [PgName("kurye_cagrildi")]
    KuryeCagrildi,
    [PgName("hazirlaniyor")]
    Hazirlaniyor,
    [PgName("iptal")]
    Iptal
}
