namespace WebApi.Entities; 

public class ProactiveNotification {
    /// <summary>Gets or sets the name of the contact.</summary>
    /// <value>The name of the contact.</value>
    public string? ContactName { get; set; }

    /// <summary>Gets or sets the phone number.</summary>
    /// <value>The phone number.</value>
    public string? Phone { get; set; }

    /// <summary>Gets or sets the email.</summary>
    /// <value>The email.</value>
    public string? Email { get; set; }
}