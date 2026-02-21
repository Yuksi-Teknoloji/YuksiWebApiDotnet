using NpgsqlTypes;

namespace Yuksi.Domain.Enums;

public enum CourierDocumentStatus
{
    [PgName("evrak_bekleniyor")]
    EvrakBekleniyor,
    [PgName("onaylandi")]
    Onaylandi,
    [PgName("reddedildi")]
    Reddedildi,
    [PgName("eksik_belge")]
    EksikBelge,
    [PgName("inceleme_bekleniyor")]
    IncelemeBekleniyor
}
