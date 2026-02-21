using NpgsqlTypes;

namespace Yuksi.Domain.Enums;

public enum ContentType
{
    [PgName("Destek")]
    Destek,
    [PgName("Hakkimizda")]
    Hakkimizda,
    [PgName("Iletisim")]
    Iletisim,
    [PgName("KullanimKosullari")]
    KullanimKosullari,
    [PgName("GizlilikPolitikasi")]
    GizlilikPolitikasi,
    [PgName("KuryeTasiyiciSözlesmesi")]
    KuryeTasiyiciSozlesmesi,
    [PgName("KuryeGizlilikSözlesmesi")]
    KuryeGizlilikSozlesmesi
}