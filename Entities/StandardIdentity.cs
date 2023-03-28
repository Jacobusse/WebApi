namespace WebApi.Entities;

/// <summary>Identity Class for Contact</summary>
public class StandardIdentity {

    /// <summary>Gets or sets the identifier.</summary>
    /// <value>The identifier.</value>
    public string Id { get; set; } = String.Empty;

    /// <summary>Initializes a new instance of the <see cref="StandardIdentity"/> class.</summary>
    /// <param name="id">The identifier.</param>
    public StandardIdentity(string id) {
        Id = id;
    }
}
