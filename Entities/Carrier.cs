namespace WebApi.Entities;

public class Carrier {
    /// <summary>Gets or sets the carrier code.</summary>
    /// <value>The carrier code.</value>
    public CarrierCode CarrierCode { get; set; }

    /// <summary>Gets or sets the name of the carrier.</summary>
    /// <value>The name of the carrier.</value>
    public string? CarrierName { get; set; }

    /// <summary>Gets or sets the company code.</summary>
    /// <value>The company code.</value>
    public string? CompanyCode { get; set; }
}
