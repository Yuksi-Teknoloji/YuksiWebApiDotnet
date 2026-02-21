using NpgsqlTypes;

namespace Yuksi.Domain.Enums;

public enum DeliveryType
{
    [PgName("yerinde")]
    Yerinde,
    [PgName("paket_servis")]
    PaketServis,
    [PgName("gel_al")]
    GelAl
}
