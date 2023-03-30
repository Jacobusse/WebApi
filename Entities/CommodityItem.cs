namespace WebApi.Entities;
    
public class CommodityItem {
    /// <summary>Gets or sets the description.</summary>
    /// <value>The description.</value>
    public string? Description { get; set; }

    /// <summary>Gets or sets the weight.</summary>
    /// <value>The weight.</value>
    public Weight? Weight { get; set; }

    /// <summary>Gets or sets the quantity.</summary>
    /// <value>The quantity.</value>
    public int? Quantity { get; set; }

    /// <summary>Gets or sets the piece count.</summary>
    /// <value>The piece count.</value>
    public int? PieceCount { get; set; }

    /// <summary>Gets or sets the type of the piece handling unit.</summary>
    /// <value>The type of the piece handling unit.</value>
    public HandlingUnitType? PieceHandlingUnitType { get; set; }

    /// <summary>Gets or sets the freight class code.</summary>
    /// <value>The freight class code.</value>
    public FreightClassCode? FreightClassCode { get; set; }

    /// <summary>Gets or sets the NMFC item number.</summary>
    /// <value>The NMFC item number.</value>
    public string? NmfcItemNumber { get; set; }

    /// <summary>Gets or sets the is hazardous.</summary>
    /// <value>The is hazardous.</value>
    public bool? IsHazardous { get; set; }

    /// <summary>Gets or sets the is new commodity.</summary>
    /// <value>The is new commodity.</value>
    public bool? IsNewCommodity { get; set; }

    /// <summary>Gets or sets the hazardous details.</summary>
    /// <value>The hazardous details.</value>
    public HazardousDetails? hazardousDetails { get; set; }
}