namespace WebApi.Entities;

public class ServiceOptions {
    /// <summary>Gets or sets the service level.</summary>
    /// <value>The service level.</value>
    public ServiceLevelCode ServiceLevel { get; set; }

    /// <summary>Gets or sets the type of the service.</summary>
    /// <value>The type of the service.</value>
    public ServiceTypeCode? ServiceType { get; set; }

    /// <summary>Gets or sets the window.</summary>
    /// <value>The window.</value>
    public WindowOptions? Window { get; set; }
}