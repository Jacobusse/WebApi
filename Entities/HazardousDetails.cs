namespace WebApi.Entities;

public class HazardousDetails {
    public string? ProperName { get; set; }
    public string? TechnicalName { get; set; }
    public HazardousIdNumber? IdNumber { get; set; }
    public HazardousClassCode? HazardousClassCode { get; set; }
    public List<HazardousClassCode> SubRiskCodes { get; set; } = new List<HazardousClassCode>();
    public PackingGroupCode? PackingGroupCode { get; set; }
    public RegulationCode? ShipmentDescriberPerCode { get; set; }
    public string? DotSpecialPermit { get; set; }
    public bool? IsReportableQuantity { get; set; }
    public bool? IsDangerousWhenWet { get; set; }
    public bool? IsLimitedQuantity { get; set; }
    public bool? IsResidue { get; set; }
    public bool? IsPortableTank { get; set; }
    public bool? IsMarinePollutant { get; set; }
    public bool? IsPoison { get; set; }
    public bool? IsPoisonInhalationHazard { get; set; }
    public InhalationHazardZone? InhalationHazardZone { get; set; }
    public string? AdditionalInfo { get; set; }
}