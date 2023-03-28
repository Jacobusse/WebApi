namespace WebApi.Entities;

public class Location {
    public string? LocationId { get; set; }
    public string? CompanyName { get; set; }
    public string? ContactName { get; set; }
    public string? Phone { get; set; }
    public string? StoreNumber { get; set; }
    public LocationType LocationType { get; set; }
    public Address? Address { get; set; }
}
