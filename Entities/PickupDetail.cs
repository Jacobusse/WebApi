namespace WebApi.Entities;

public class PickupDetail {

    public string? ContactName { get; set; }
    public string? Phone { get; set; }
    public string? PickupDate { get; set; }
    public string? DockReadyTime { get; set; }
    public string? DockCloseTime { get; set; }
    public string? DriverNote { get; set; }
    public string? AdditionalNote { get; set; }
    public string? Email { get; set; }
    public bool? IsCertifiedPickup { get; set; }
    public string? Department { get; set; }
}