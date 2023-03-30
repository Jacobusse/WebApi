namespace WebApi.Entities;

public class LineItem {
    /// <summary>Gets or sets the count.</summary>
    /// <value>The count.</value>
    public int Count { get; set; }

    /// <summary>Gets or sets the type of the handling unit.</summary>
    /// <value>The type of the handling unit.</value>
    public HandlingUnitType? HandlingUnitType { get; set; }

    /// <summary>The length</summary>
    /// <value>The length.</value>
    public Measurement? Length { get; set; }

    /// <summary>The width</summary>
    /// <value>The width.</value>
    public Measurement? Width { get; set; }

    /// <summary>The height</summary>
    /// <value>The height.</value>
    public Measurement? Height { get; set; }

    /// <summary>Gets or sets a value indicating whether this instance is stackable.</summary>
    /// <value><c>true</c> if this instance is stackable; otherwise, <c>false</c>.</value>
    public bool IsStackable { get; set; }

    /// <summary>Gets or sets the commodities.</summary>
    /// <value>The commodities.</value>
    public List<CommodityItem> Commodities { get; set; } = new List<CommodityItem>();

}
