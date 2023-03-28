namespace WebApi.Entities;

public class LineItem {

    public int Count { get; set; }
    public HandlingUnitType? HandlingUnitType { get; set; }
    public Measurement? Length;
    public Measurement? Width;
    public Measurement? Height;
    public bool IsStackable { get; set; }
    public List<CommodityItem> Commodities { get; set; } = new List<CommodityItem>();

}
