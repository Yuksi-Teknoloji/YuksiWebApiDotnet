using NpgsqlTypes;

namespace Yuksi.Domain.Enums;

public enum VehicleFeature
{
    [PgName("cooling")]
    Cooling,
    [PgName("withSeats")]
    WithSeats,
    [PgName("withoutSeats")]
    WithoutSeats
}
