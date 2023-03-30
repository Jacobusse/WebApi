namespace WebApi.Entities;

public class ReferenceNumber {
    /// <summary>Gets or sets the value.</summary>
    /// <value>The value.</value>
    public string? Value { get; set; }

    /// <summary>Gets or sets the type of the reference number.</summary>
    /// <value>The type of the reference number.</value>
    public ReferenceNumberType? ReferenceNumberType { get; set; }

    /// <summary>Gets or sets the store number.</summary>
    /// <value>The store number.</value>
    public string? StoreNumber { get; set; }

    /// <summary>Gets or sets the department.</summary>
    /// <value>The department.</value>
    public string? Department { get; set; }

    /// <summary>Gets or sets the weight.</summary>
    /// <value>The weight.</value>
    public Weight? Weight { get; set; }

    /// <summary>Gets or sets the count.</summary>
    /// <value>The count.</value>
    public int? Count { get; set; }

    /// <summary>Gets or sets the waive requirements.</summary>
    /// <value>The waive requirements.</value>
    public bool? WaiveRequirements { get; set; }
}