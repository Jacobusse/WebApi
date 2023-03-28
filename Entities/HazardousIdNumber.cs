namespace WebApi.Entities;

public class HazardousIdNumber {

    public enum HazardousIdNumberType {
        NA,
        UN,
        ID
    }

    public string Value { get; set; } = string.Empty;
    public HazardousIdNumberType IdNumberType { get; set; }
}