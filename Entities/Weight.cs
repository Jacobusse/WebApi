namespace WebApi.Entities;

public class Weight {

    public enum WeightUnitType {
        /// <summary>The Pound</summary>
        LB,
        /// <summary>The Pounds</summary>
        LBS
    }

    /// <summary>Gets or sets the value.</summary>
    /// <value>The value.</value>
    public int Value { get; set; }

    /// <summary>Gets or sets the unit.</summary>
    /// <value>The unit.</value>
    public WeightUnitType Unit { get; set; }
}