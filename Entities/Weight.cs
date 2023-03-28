namespace WebApi.Entities;

public class Weight {

    public enum WeightUnit {
        LB, //("LB", "Pound"),
        LBS //("LBS", "Pounds");
    }

    public int Value { get; set; }
    public WeightUnit Unit { get; set; }
}