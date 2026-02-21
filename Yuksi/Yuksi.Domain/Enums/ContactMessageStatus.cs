using NpgsqlTypes;

namespace Yuksi.Domain.Enums;

public enum ContactMessageStatus
{
    [PgName("Archived")]
    Archived,
    [PgName("Read")]
    Read,
    [PgName("New")]
    New
}