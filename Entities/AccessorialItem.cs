namespace WebApi.Entities;

/// <summary>Accessorial Item Class</summary>
public class AccessorialItem {
    /// <summary>Gets or sets the accessorial code.</summary>
    /// <value>The accessorial code.</value>
    public string? AccessorialCode { get; set; }

    /// <summary>Gets or sets the payment term.</summary>
    /// <value>The payment term.</value>
    public PaymentTerm? PaymentTerm { get; set; }
}