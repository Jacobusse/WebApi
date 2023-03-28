namespace WebApi.Entities;

public class Temperature {

    public enum TemperatureUnit {
        C, // CELSIUS("C", "Celsius"),
        F  // FAHRENHEIT("F", "Fahrenheit");
    }

    public decimal Value { get; set; }
    public TemperatureUnit Unit { get; set; }
}