namespace WebApi.Entities;

public class Temperature {

    public enum TemperatureUnitType {
        /// <summary>Celsius</summary>
        C,
        /// <summary>Fahrenheit</summary>
        F
    }

    /// <summary>Gets or sets the value.</summary>
    /// <value>The value.</value>
    public decimal Value { get; set; }

    /// <summary>Gets or sets the unit.</summary>
    /// <value>The unit.</value>
    public TemperatureUnitType Unit { get; set; }
}