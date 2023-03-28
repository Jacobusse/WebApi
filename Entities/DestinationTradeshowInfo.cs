namespace WebApi.Entities;

public class DestinationTradeshowInfo : TradeshowInfo {

    public enum DeliverToCode {
        A = 105,
        S = 106
    }

    public DeliverToCode DeliverTo { get; set; }
    public DateOnly DeliverDate { get; set; }
}