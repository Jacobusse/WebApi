namespace WebApi.Entities;
    
public class CommodityItem {
    public string? CommodityDescription { get; set; }
    public Weight? Weight { get; set; }
    public int? Quantity { get; set; }
    public int? PieceCount { get; set; }
    public HandlingUnitType? PieceHandlingUnitType { get; set; }
    public FreightClassCode? FreightClassCode { get; set; }
    public string? NmfcItemNumber { get; set; }
    public bool? IsHazardous { get; set; }
    public bool? IsNewCommodity { get; set; }
    public HazardousDetails? hazardousDetails { get; set; }
}