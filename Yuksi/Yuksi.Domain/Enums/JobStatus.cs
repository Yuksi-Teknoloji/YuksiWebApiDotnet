using NpgsqlTypes;

namespace Yuksi.Domain.Enums;

public enum JobStatus
{
    [PgName("delivered")]
    Delivered,
    [PgName("cancelled")]
    Cancelled,
    [PgName("pending")]
    Pending,
    [PgName("accepted")]
    Accepted,
    [PgName("picked_up")]
    PickedUp,
    [PgName("arrived")]
    Arrived
}
