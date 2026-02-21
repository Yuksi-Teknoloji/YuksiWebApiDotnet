using NpgsqlTypes;

namespace Yuksi.Domain.Enums;

public enum VehicleTemplate
{
    [PgName("minivan")]
    Minivan,
    [PgName("kamyonet")]
    Kamyonet,
    [PgName("kamyon")]
    Kamyon,
    [PgName("motorcycle")]
    Motorcycle,
    [PgName("panelvan")]
    Panelvan
}
