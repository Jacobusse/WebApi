namespace WebApi.Entities;

public class PickupDetail {
    /// <summary>Gets or sets the name of the contact.</summary>
    /// <value>The name of the contact.</value>
    public string? ContactName { get; set; }

    /// <summary>Gets or sets the phone number.</summary>
    /// <value>The phone number.</value>
    public string? Phone { get; set; }

    /// <summary>Gets or sets the pickup date.</summary>
    /// <value>The pickup date.</value>
    public string? PickupDate { get; set; }

    /// <summary>Gets or sets the dock ready time.</summary>
    /// <value>The dock ready time.</value>
    public string? DockReadyTime { get; set; }

    /// <summary>Gets or sets the dock close time.</summary>
    /// <value>The dock close time.</value>
    public string? DockCloseTime { get; set; }

    /// <summary>Gets or sets the driver note.</summary>
    /// <value>The driver note.</value>
    public string? DriverNote { get; set; }

    /// <summary>Gets or sets the additional note.</summary>
    /// <value>The additional note.</value>
    public string? AdditionalNote { get; set; }

    /// <summary>Gets or sets the email.</summary>
    /// <value>The email.</value>
    public string? Email { get; set; }

    /// <summary>Gets or sets the is certified pickup.</summary>
    /// <value>The is certified pickup.</value>
    public bool? IsCertifiedPickup { get; set; }

    /// <summary>Gets or sets the department.</summary>
    /// <value>The department.</value>
    public string? Department { get; set; }
}