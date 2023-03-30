namespace WebApi.Entities;

public class Measurement {
    
    public enum MeasurementUnitType {
        /// <summary>The inch</summary>
        IN
    }

    /// <summary>The value</summary>
    /// <value>The value.</value>
    public decimal Value { get; set; } = decimal.MinValue;

    /// <summary>The unit</summary>
    /// <value>The unit.</value>
    public MeasurementUnitType Unit { get; set; }
}