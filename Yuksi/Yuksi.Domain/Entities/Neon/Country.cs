namespace Yuksi.Domain;

public partial class Country
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Iso3 { get; set; }

    public string? NumericCode { get; set; }

    public string? Iso2 { get; set; }

    public string? Phonecode { get; set; }

    public string? Capital { get; set; }

    public string? Currency { get; set; }

    public string? CurrencyName { get; set; }

    public string? CurrencySymbol { get; set; }

    public string? Tld { get; set; }

    public string? Native { get; set; }

    public long? Population { get; set; }

    public long? Gdp { get; set; }

    public string? Region { get; set; }

    public long? RegionId { get; set; }

    public string? Subregion { get; set; }

    public long? SubregionId { get; set; }

    public string? Nationality { get; set; }

    public string? Timezones { get; set; }

    public string? Translations { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public string? Emoji { get; set; }

    public string? EmojiU { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public short Flag { get; set; }

    public string? WikiDataId { get; set; }
}
