namespace WebApi.Entities;

public class DestinationTradeshowInfo : TradeshowInfo {

    /// <summary>Deliver To Code</summary>
    public enum DeliverToCode {
        A = 105,
        S = 106
    }

    /// <summary>Gets or sets the deliver to.</summary>
    /// <value>The deliver to.</value>
    public DeliverToCode DeliverTo { get; set; }

    /// <summary>Gets or sets the deliver date.</summary>
    /// <value>The deliver date.</value>
    public DateOnly? DeliverDate { get; set; }
}