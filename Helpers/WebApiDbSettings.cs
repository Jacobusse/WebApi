namespace WebApi.Helpers;

/// <summary>Settings Container for Web API</summary>
public class WebApiDbSettings {
    /// <summary>Gets or sets the connection string.</summary>
    /// <value>The connection string.</value>
    public string ConnectionString { get; set; } = null!;

    /// <summary>Gets or sets the name of the database.</summary>
    /// <value>The name of the database.</value>
    public string DatabaseName { get; set; } = null!;

    /// <summary>Gets or sets the name of the contact collection.</summary>
    /// <value>The name of the contact collection.</value>
    public string ContactCollectionName { get; set; } = null!;

    /// <summary>Gets or sets the name of the bill of lading collection.</summary>
    /// <value>The name of the bill of lading collection.</value>
    public string BillOfLadingCollectionName { get; set; }
}
