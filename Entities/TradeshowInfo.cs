namespace WebApi.Entities;

public class TradeshowInfo {
    /// <summary>Gets or sets the name of the tradeshow.</summary>
    /// <value>The name of the tradeshow.</value>
    public string TradeshowName { get; set; } = string.Empty;

    /// <summary>Gets or sets the booth number.</summary>
    /// <value>The booth number.</value>
    public string BoothNumber { get; set; } = string.Empty;
}