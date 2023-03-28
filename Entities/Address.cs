namespace WebApi.Entities;

/// <summary>Address Class</summary>
public class Address {

    /// <summary>Gets or sets the street.</summary>
    /// <value>The street.</value>
    public string? Street { get; set; }

    /// <summary>Gets or sets the city.</summary>
    /// <value>The city.</value>
    public string? City { get; set; }

    /// <summary>Gets or sets the region code.</summary>
    /// <value>The region code.</value>
    public string? StateCode { get; set; }

    /// <summary>Gets or sets the postal code.</summary>
    /// <value>The postal code.</value>
    public string? PostalCode { get; set; }

    /// <summary>Gets or sets the country code.</summary>
    /// <value>The country code.</value>
    public CountryCode? CountryCode { get; set; }
}