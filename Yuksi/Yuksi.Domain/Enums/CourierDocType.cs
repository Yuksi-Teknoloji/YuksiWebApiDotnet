using NpgsqlTypes;

namespace Yuksi.Domain.Enums;

public enum CourierDocType
{
    [PgName("EhliyetOn")]
    EhliyetOn,
    [PgName("EhliyetArka")]
    EhliyetArka,
    [PgName("RuhsatOn")]
    RuhsatOn,
    [PgName("RuhsatArka")]
    RuhsatArka,
    [PgName("KimlikOn")]
    KimlikOn,
    [PgName("KimlikArka")]
    KimlikArka,
    [PgName("KBelgesi")]
    KBelgesi,
    [PgName("P1Belgesi")]
    P1Belgesi,
    [PgName("Psikoteknik")]
    Psikoteknik,
    [PgName("SRC")]
    SRC,
    [PgName("AdliSicil")]
    AdliSicil,
    [PgName("VergiLevhasi")]
    VergiLevhasi
}
