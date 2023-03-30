namespace WebApi.Entities;

public class HazardousIdNumber {

    /// <summary>Hazardous Id Number Type</summary>
    public enum HazardousIdNumberType {
        NA,
        UN,
        ID
    }

    /// <summary>Gets or sets the value.</summary>
    /// <value>The value.</value>
    public string Value { get; set; } = string.Empty;

    /// <summary>Gets or sets the type of the identifier number.</summary>
    /// <value>The type of the identifier number.</value>
    public HazardousIdNumberType IdNumberType { get; set; }
}