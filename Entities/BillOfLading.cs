using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace WebApi.Entities;

/// <summary>Bill of Lading Class</summary>
public class BillOfLading {

    /// <summary>Gets or sets the identifier.</summary>
    /// <value>The identifier.</value>
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = string.Empty;

    /// <summary>Gets or sets the source type. ECM or WEB</summary>
    /// <value>The source.</value>
    public SourceType? Source { get; set; }

    /// <summary>Gets or sets the status type.</summary>
    /// <value>The status.</value>
    public StatusType? Status { get; set; }

    /// <summary>Gets or sets the role.</summary>
    /// <value>The role.</value>
    public string? Role { get; set; }

    /// <summary>Gets or sets the name of the template.</summary>
    /// <value>The name of the template.</value>
    public string? TemplateName { get; set; }

    /// <summary>Gets or sets the user location.</summary>
    /// <value>The user location.</value>
    public Location UserLocation { get; set; } = new Location();

    /// <summary>Gets or sets the ship from location.</summary>
    /// <value>The ship from location.</value>
    public Location? ShipFromLocation { get; set; }

    /// <summary>Gets or sets the ship to location.</summary>
    /// <value>The ship to location.</value>
    public Location? ShipToLocation { get; set; }

    /// <summary>Gets or sets the bill to location.</summary>
    /// <value>The bill to location.</value>
    public Location? BillToLocation { get; set; }

    /// <summary>Gets or sets the customs broker location.</summary>
    /// <value>The customs broker location.</value>
    public Location? CustomsBrokerLocation { get; set; }

    /// <summary>Gets or sets the forwarder location.</summary>
    /// <value>The forwarder location.</value>
    public Location? ForwarderLocation { get; set; }

    /// <summary>Gets or sets the carrier.</summary>
    /// <value>The carrier.</value>
    public Carrier? Carrier { get; set; } = new Carrier();

    /// <summary>Gets or sets the payment term.</summary>
    /// <value>The payment term.</value>
    public PaymentTerm? PaymentTerm { get; set; }

    /// <summary>Gets or sets the pro number.</summary>
    /// <value>The pro number.</value>
    public string? ProNumber { get; set; }

    /// <summary>Gets or sets the trailer number.</summary>
    /// <value>The trailer number.</value>
    public string? TrailerNumber { get; set; }

    /// <summary>Gets or sets the line items.</summary>
    /// <value>The line items.</value>
    public List<LineItem> LineItems { get; set; } = new List<LineItem>();

    /// <summary>Gets or sets the hazardous information.</summary>
    /// <value>The hazardous information.</value>
    public HazardousInfo? HazardousInfo { get; set; }

    /// <summary>Gets or sets the service options.</summary>
    /// <value>The service options.</value>
    public ServiceOptions? ServiceOptions { get; set; }

    /// <summary>Gets or sets the pickup.</summary>
    /// <value>The pickup.</value>
    public PickupDetail? Pickup { get; set; }

    /// <summary>Gets or sets the quote number.</summary>
    /// <value>The quote number.</value>
    public string? QuoteNumber { get; set; }

    /// <summary>Gets or sets the reference numbers.</summary>
    /// <value>The reference numbers.</value>
    public List<ReferenceNumber> ReferenceNumbers { get; set; } = new List<ReferenceNumber>();

    /// <summary>Gets or sets the is editable.</summary>
    /// <value>The is editable.</value>
    public bool? IsEditable { get; set; }

    /// <summary>Gets or sets the is pickup requested.</summary>
    /// <value>The is pickup requested.</value>
    public bool? IsPickupRequested { get; set; }

    /// <summary>Gets or sets the is billed.</summary>
    /// <value>The is billed.</value>
    public bool? IsBilled { get; set; }

    /// <summary>Gets or sets the is excess liability.</summary>
    /// <value>The is excess liability.</value>
    public bool? IsExcessLiability { get; set; }

    /// <summary>Gets or sets the declared value.</summary>
    /// <value>The declared value.</value>
    public Money? DeclaredValue { get; set; }

    /// <summary>Gets or sets the declared value unit.</summary>
    /// <value>The declared value unit.</value>
    public string? DeclaredValueUnit { get; set; }

    /// <summary>Gets or sets the coverage amount.</summary>
    /// <value>The coverage amount.</value>
    public Money? coverageAmount { get; set; }

    /// <summary>Gets or sets the additional services note.</summary>
    /// <value>The additional services note.</value>
    public string? AdditionalServicesNote { get; set; }

    /// <summary>Gets or sets the accessorials.</summary>
    /// <value>The accessorials.</value>
    public List<AccessorialItem> Accessorials { get; set; } = new List<AccessorialItem>();

    /// <summary>Gets or sets the dock instructions.</summary>
    /// <value>The dock instructions.</value>
    public string? DockInstructions { get; set; }

    /// <summary>Gets or sets the chemical instructions.</summary>
    /// <value>The chemical instructions.</value>
    public string? ChemicalInstructions { get; set; }

    /// <summary>Gets or sets the food instructions.</summary>
    /// <value>The food instructions.</value>
    public string? FoodInstructions { get; set; }

    /// <summary>Gets or sets the freezeable information.</summary>
    /// <value>The freezeable information.</value>
    public Temperature? FreezeableInfo { get; set; }

    /// <summary>Gets or sets the pallet weight.</summary>
    /// <value>The pallet weight.</value>
    public Weight? PalletWeight { get; set; }

    /// <summary>Gets or sets the is government contract.</summary>
    /// <value>The is government contract.</value>
    public bool? IsGovernmentContract { get; set; }

    /// <summary>Gets or sets the government contract number.</summary>
    /// <value>The government contract number.</value>
    public string? GovernmentContractNumber { get; set; }

    /// <summary>Gets or sets the origin tradeshow information.</summary>
    /// <value>The origin tradeshow information.</value>
    public TradeshowInfo? OriginTradeshowInfo { get; set; }

    /// <summary>Gets or sets the destinate tradeshow information.</summary>
    /// <value>The destinate tradeshow information.</value>
    public DestinationTradeshowInfo? DestinateTradeshowInfo { get; set; }

    /// <summary>Gets or sets a value indicating whether this instance is terms and conditions accepted.</summary>
    /// <value><c>true</c> if this instance is terms and conditions accepted; otherwise, <c>false</c>.</value>
    public bool IsTermsAndConditionsAccepted { get; set; } = false;

    /// <summary>Gets or sets the proactive notification.</summary>
    /// <value>The proactive notification.</value>
    public ProactiveNotification? ProactiveNotification { get; set; }
}

