namespace WebApi.Entities; 

public class Money {

    public enum MoneyUnitType {
        /// <summary>The united states dollar</summary>
        USD
    }

    /// <summary>The value</summary>
    /// <value>The value.</value>
    public decimal Value { get; set; } = decimal.MinValue;

    /// <summary>The unit</summary>
    /// <value>The unit.</value>
    public MoneyUnitType Unit { get; set; }

}