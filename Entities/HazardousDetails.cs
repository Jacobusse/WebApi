namespace WebApi.Entities;

public class HazardousDetails {
    /// <summary>Gets or sets the proper name of the hazardous item.</summary>
    /// <value>The proper name.</value>
    public string? ProperName { get; set; }

    /// <summary>Gets or sets the technical name of the hazardous item.</summary>
    /// <value>The technical name.</value>
    public string? TechnicalName { get; set; }

    /// <summary>Gets or sets the identifier number.</summary>
    /// <value>The identifier number.</value>
    public HazardousIdNumber? IdNumber { get; set; }

    /// <summary>Gets or sets the hazardous class code.</summary>
    /// <value>The hazardous class code.</value>
    public HazardousClassCode? HazardousClassCode { get; set; }

    /// <summary>Gets or sets the sub risk codes.</summary>
    /// <value>The sub risk codes.</value>
    public List<HazardousClassCode> SubRiskCodes { get; set; } = new List<HazardousClassCode>();

    /// <summary>Gets or sets the packing group code.</summary>
    /// <value>The packing group code.</value>
    public PackingGroupCode? PackingGroupCode { get; set; }

    /// <summary>Gets or sets the shipment describer per code.</summary>
    /// <value>The shipment describer per code.</value>
    public RegulationCode? ShipmentDescriberPerCode { get; set; }

    /// <summary>Gets or sets the dot special permit.</summary>
    /// <value>The dot special permit.</value>
    public string? DotSpecialPermit { get; set; }

    /// <summary>Gets or sets the is reportable quantity.</summary>
    /// <value>The is reportable quantity.</value>
    public bool? IsReportableQuantity { get; set; }

    /// <summary>Gets or sets the is dangerous when wet.</summary>
    /// <value>The is dangerous when wet.</value>
    public bool? IsDangerousWhenWet { get; set; }

    /// <summary>Gets or sets the is limited quantity.</summary>
    /// <value>The is limited quantity.</value>
    public bool? IsLimitedQuantity { get; set; }

    /// <summary>Gets or sets the is residue.</summary>
    /// <value>The is residue.</value>
    public bool? IsResidue { get; set; }

    /// <summary>Gets or sets the is portable tank.</summary>
    /// <value>The is portable tank.</value>
    public bool? IsPortableTank { get; set; }

    /// <summary>Gets or sets the is marine pollutant.</summary>
    /// <value>The is marine pollutant.</value>
    public bool? IsMarinePollutant { get; set; }

    /// <summary>Gets or sets the is poison.</summary>
    /// <value>The is poison.</value>
    public bool? IsPoison { get; set; }

    /// <summary>Gets or sets the is poison inhalation hazard.</summary>
    /// <value>The is poison inhalation hazard.</value>
    public bool? IsPoisonInhalationHazard { get; set; }

    /// <summary>Gets or sets the inhalation hazard zone.</summary>
    /// <value>The inhalation hazard zone.</value>
    public InhalationHazardZone? InhalationHazardZone { get; set; }

    /// <summary>Gets or sets the additional information.</summary>
    /// <value>The additional information.</value>
    public string? AdditionalInfo { get; set; }
}