using NpgsqlTypes;

namespace Yuksi.Domain.Enums;

public enum OrderType
{
    [PgName("yerinde")]
    Yerinde,
    [PgName("paket_servis")]
    PaketServis,
    [PgName("gel_al")]
    GelAl
}
