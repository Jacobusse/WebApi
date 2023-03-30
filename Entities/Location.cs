namespace WebApi.Entities;

public class Location {
    /// <summary>Gets or sets the location identifier.</summary>
    /// <value>The location identifier.</value>
    public string? LocationId { get; set; }

    /// <summary>Gets or sets the name of the company.</summary>
    /// <value>The name of the company.</value>
    public string? CompanyName { get; set; }

    /// <summary>Gets or sets the name of the contact.</summary>
    /// <value>The name of the contact.</value>
    public string? ContactName { get; set; }

    /// <summary>Gets or sets the phone number.</summary>
    /// <value>The phone number.</value>
    public string? Phone { get; set; }

    /// <summary>Gets or sets the store number.</summary>
    /// <value>The store number.</value>
    public string? StoreNumber { get; set; }

    /// <summary>Gets or sets the type of the location.</summary>
    /// <value>The type of the location.</value>
    public LocationType? LocationType { get; set; }

    /// <summary>Gets or sets the address.</summary>
    /// <value>The address.</value>
    public Address? Address { get; set; }
}
