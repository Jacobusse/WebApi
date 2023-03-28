namespace WebApi.Entities;

public class Measurement {
    public enum MeasurementUnitType {
        IN
    }

    public decimal value;
    public MeasurementUnitType unit;
}