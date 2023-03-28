namespace WebApi.Entities;

public class ReferenceNumber {
    public string? Value { get; set; }
    public ReferenceNumberType? ReferenceNumberType { get; set; }
    public string? StoreNumber { get; set; }
    public string? Cepartment { get; set; }
    public Weight? Weight { get; set; }
    public int? Count { get; set; }
    public bool? WaiveRequirements { get; set; }
}