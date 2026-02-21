using NpgsqlTypes;

namespace Yuksi.Domain.Enums;

public enum DocType
{
    [PgName("license")]
    License,
    [PgName("criminal_record")]
    CriminalRecord,
    [PgName("vehicle_insurance")]
    VehicleInsurance
}
