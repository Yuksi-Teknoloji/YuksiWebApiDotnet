using NpgsqlTypes;

namespace Yuksi.Domain.Enums;

public enum CourierOrderAction
{
    [PgName("kabul_etti")]
    KabulEtti,
    [PgName("reddetti")]
    Reddetti
}
