using MongoDB.Driver.Core.Events;
using System.Runtime.CompilerServices;
using WebApi.Entities;
using static WebApi.Entities.DestinationTradeshowInfo;

namespace WebApi.Helpers;

public static class EnumUtils {

    static int _codeOffset = 256;
    static string[] _listEnum = new string[384];

    /// <summary>Descriptions the specified payment term.</summary>
    /// <param name="paymentTerm">The payment term.</param>
    /// <returns>Description</returns>
    public static string Description(this PaymentTerm paymentTerm) {
        if (_listEnum[(int)paymentTerm] == null) {
            _listEnum[(int)PaymentTerm.PREPAID] = "Prepaid";
            _listEnum[(int)PaymentTerm.COLLECT] = "Collect";
        }

        return _listEnum[(int)paymentTerm];
    }

    /// <summary>Codes the specified payment term.</summary>
    /// <param name="paymentTerm">The payment term.</param>
    /// <returns>Code</returns>
    public static string Code(this PaymentTerm paymentTerm) {
        if (_listEnum[_codeOffset + (int)paymentTerm] == null) {
            _listEnum[_codeOffset + (int)PaymentTerm.PREPAID] = "P";
            _listEnum[_codeOffset + (int)PaymentTerm.COLLECT] = "C";
        }

        return _listEnum[_codeOffset + (int)paymentTerm];
    }

    /// <summary>Finds the payment term.</summary>
    /// <param name="code">The code.</param>
    /// <returns></returns>
    public static PaymentTerm? FindPaymentTerm(string code) {
        switch (code.ToUpper()) {
            case "PREPAID":
            case "P": return PaymentTerm.PREPAID;
            case "COLLECT":
            case "C": return PaymentTerm.COLLECT;
        }

        return null;
    }

    /// <summary>Set by specified code.</summary>
    /// <param name="paymentTerm">The payment term.</param>
    /// <param name="code">The code.</param>
    /// <returns></returns>
    public static void Set(this PaymentTerm paymentTerm, string code) {
        PaymentTerm? val = FindPaymentTerm(code);
        paymentTerm = val ?? paymentTerm;
    }

    /// <summary>Descriptions the specified status type.</summary>
    /// <param name="status">Type of the status.</param>
    /// <returns>Description</returns>
    public static string Description(this StatusType status) {
        if (_listEnum[(int)status] == null) {
            _listEnum[(int)StatusType.UNKNOWN] = "Unknown";
            _listEnum[(int)StatusType.DELETED] = "Deleted";
            _listEnum[(int)StatusType.TEMPLATE] = "Template";
            _listEnum[(int)StatusType.DRAFT] = "Draft";
            _listEnum[(int)StatusType.COMPLETE] = "Complete";
        }

        return _listEnum[(int)status];
    }

    /// <summary>Codes the specified status.</summary>
    /// <param name="status">The status.</param>
    /// <returns></returns>
    public static string Code(this StatusType status) {
        if (_listEnum[_codeOffset + (int)status] == null) {
            _listEnum[_codeOffset + (int)StatusType.UNKNOWN] = "?";
            _listEnum[_codeOffset + (int)StatusType.DELETED] = " ";
            _listEnum[_codeOffset + (int)StatusType.TEMPLATE] = "T";
            _listEnum[_codeOffset + (int)StatusType.DRAFT] = "I";
            _listEnum[_codeOffset + (int)StatusType.COMPLETE] = "C";
        }

        return _listEnum[_codeOffset + (int)status];
    }

    /// <summary>Finds the type of the status.</summary>
    /// <param name="code">The code.</param>
    /// <returns></returns>
    public static StatusType? FindStatusType(string code) {
        switch (code.ToUpper()) {
            case "UNKNOWN":
            case "?": return StatusType.UNKNOWN;
            case "DELETED":
            case " ": return StatusType.DELETED;
            case "TEMPLATE":
            case "T": return StatusType.TEMPLATE;
            case "DRAFT":
            case "I": return StatusType.DRAFT;
            case "COMPLETE":
            case "C":
            case "D": return StatusType.COMPLETE;
        }

        return null;
    }

    /// <summary>Sets the specified code.</summary>
    /// <param name="status">The status.</param>
    /// <param name="code">The code.</param>
    public static void Set(this StatusType status, string code) {
        StatusType? val = FindStatusType(code);
        status = val ?? status; 
    }

    /// <summary>Descriptions the specified source type.</summary>
    /// <param name="source">Type of the source.</param>
    /// <returns>Description</returns>
    public static string Description(this SourceType source) {
        return source.ToString();
    }

    /// <summary>Codes the specified source.</summary>
    /// <param name="source">The source.</param>
    /// <returns>Code</returns>
    public static string Code(this SourceType source) {
        return source.ToString();
    }

    /// <summary>Finds the type of the source.</summary>
    /// <param name="code">The code.</param>
    /// <returns></returns>
    public static SourceType? FindSourceType(string code) {
        try {
            return Enum.Parse<SourceType>(code);
        } catch {
            return null;
        }
    }

    /// <summary>Sets the specified code.</summary>
    /// <param name="source">The source.</param>
    /// <param name="code">The code.</param>
    public static void Set(this SourceType source, string code) {
        SourceType? val = FindSourceType(code);
        source = val ?? source;
    }

    /// <summary>Descriptions the specified location type.</summary>
    /// <param name="locationType">Type of the location.</param>
    /// <returns>Description</returns>
    public static string Description(this LocationType locationType) { 
        if (_listEnum[(int)locationType] == null) { 
            _listEnum[(int)LocationType.COMMERCIAL_WITH_DOCK] = "Commercial with forklift or dock";
            _listEnum[(int)LocationType.COMMERCIAL_WITHOUT_DOCK] = "Commercial without forklift or dock";
            _listEnum[(int)LocationType.NON_COMMERCIAL] = "Residential or non-commercial";
            _listEnum[(int)LocationType.TRADESHOW] = "Tradeshow";
            _listEnum[(int)LocationType.TERMINAL] = "Pickup or dropoff at Terminal";
        }

        return _listEnum[(int)locationType];
    }

    /// <summary>Codes the specified location type.</summary>
    /// <param name="locationType">Type of the location.</param>
    /// <returns></returns>
    public static string Code(this LocationType locationType) {
        if (_listEnum[_codeOffset + (int)locationType] == null) {
            _listEnum[_codeOffset + (int)LocationType.COMMERCIAL_WITH_DOCK] = "CWDF";
            _listEnum[_codeOffset + (int)LocationType.COMMERCIAL_WITHOUT_DOCK] = "CXDF";
            _listEnum[_codeOffset + (int)LocationType.NON_COMMERCIAL] = "RESD";
            _listEnum[_codeOffset + (int)LocationType.TRADESHOW] = "SHOW";
            _listEnum[_codeOffset + (int)LocationType.TERMINAL] = "TERM";
        }

        return _listEnum[_codeOffset + (int)locationType];
    }

    /// <summary>If Location Type Needs the liftgate.</summary>
    /// <param name="locationType">Type of the location.</param>
    /// <returns></returns>
    public static bool NeedsLiftgate(this LocationType locationType) {
        switch (locationType) {
            case LocationType.COMMERCIAL_WITHOUT_DOCK:
            case LocationType.NON_COMMERCIAL:
                return true;
        }

        return false;
    }

    /// <summary>Finds the type of the location.</summary>
    /// <param name="code">The code.</param>
    /// <returns></returns>
    public static LocationType? FindLocationType(string code) {
        switch (code.ToUpper()) {
            case "COMMERCIAL_WITH_DOCK":
            case "CWDF": return LocationType.COMMERCIAL_WITH_DOCK;
            case "COMMERCIAL_WITHOUT_DOCK":
            case "CXDF": return LocationType.COMMERCIAL_WITHOUT_DOCK;
            case "NON_COMMERCIAL":
            case "RESIDENTIAL":
            case "RESD": return LocationType.NON_COMMERCIAL;
            case "TRADESHOW":
            case "SHOW": return LocationType.TRADESHOW;
            case "TERMINAL":
            case "TERM": return LocationType.TERMINAL;
        }
        return null;
    }

    /// <summary>Sets the specified code.</summary>
    /// <param name="locationType">Type of the location.</param>
    /// <param name="code">The code.</param>
    public static void Set(this LocationType locationType, string code) {
        LocationType? val = FindLocationType(code);
        locationType = val ?? locationType;
    }

    /// <summary>Descriptions the specified country code.</summary>
    /// <param name="countryCode">The country code.</param>
    /// <returns>Description</returns>
    public static string Description(this CountryCode countryCode) {
        if (_listEnum[(int)countryCode] == null) {
            _listEnum[(int)CountryCode.USA] = "United States";
            _listEnum[(int)CountryCode.CAN] = "Canada";
            _listEnum[(int)CountryCode.MEX] = "Mexico";
        }

        return _listEnum[(int)countryCode];
    }

    /// <summary>Codes the specified country code.</summary>
    /// <param name="countryCode">The country code.</param>
    /// <returns></returns>
    public static string Code(this CountryCode countryCode) {
        return countryCode.ToString();
    }

    /// <summary>Finds the country code.</summary>
    /// <param name="code">The code.</param>
    /// <returns></returns>
    public static CountryCode? FindCountryCode(string code) {
        switch (code.ToUpper()) {
            case "UNITED STATES":
            case "USA": return CountryCode.USA;
            case "CANADA":
            case "CAN": return CountryCode.CAN;
            case "MEXICO":
            case "MEX": return CountryCode.MEX;
        }

        return null;
    }

    /// <summary>Sets the specified code.</summary>
    /// <param name="countryCode">The country code.</param>
    /// <param name="code">The code.</param>
    public static void Set(this CountryCode countryCode, string code) {
        CountryCode? val = FindCountryCode(code);
        countryCode = val ?? countryCode;
    }

    /// <summary>Descriptions the specified carrier code.</summary>
    /// <param name="carrierCode">The carrier code.</param>
    /// <returns>Description</returns>
    public static string Description(this CarrierCode carrierCode) {
        if (_listEnum[(int)carrierCode] == null) {
            _listEnum[(int)CarrierCode.RDWY] = "Yellow";
            _listEnum[(int)CarrierCode.YELLOW] = "My Yellow"; // Duplicate RDWY
            _listEnum[(int)CarrierCode.HMES] = "Holland";
            _listEnum[(int)CarrierCode.RETL] = "Reddaway";
            _listEnum[(int)CarrierCode.NPME] = "NewPenn";
            _listEnum[(int)CarrierCode.REIM] = "YRC Freight";
            _listEnum[(int)CarrierCode.MEIQ] = "Yellow Logistics";
            _listEnum[(int)CarrierCode.OTHR] = "Other";
        }

        return _listEnum[(int)carrierCode];
    }

    /// <summary>Codes the specified carrier code.</summary>
    /// <param name="carrierCode">The carrier code.</param>
    /// <returns></returns>
    public static string Code(this CarrierCode carrierCode) {
        return carrierCode.ToString();
    }

    /// <summary>Finds the carrier code.</summary>
    /// <param name="code">The code.</param>
    /// <returns></returns>
    public static CarrierCode FindCarrierCode(string code) {
        switch (code.ToUpper()) {
            case "YRC":
            case "RDWY": return CarrierCode.RDWY;
            case "MY YELLOW":
            case "RDWY2":
            case "YELLOW": return CarrierCode.YELLOW;
            case "HOLLAND":
            case "HMES": return CarrierCode.HMES;
            case "REDDAWAY":
            case "RETL": return CarrierCode.RETL;
            case "NEW PENN":
            case "NEWPENN":
            case "NPME": return CarrierCode.NPME;
            case "YRC FREIGHT":
            case "REIM": return CarrierCode.REIM;
            case "YELLOW LOGISTICS":
            case "MEIQ": return CarrierCode.MEIQ;
            default: return CarrierCode.OTHR;
        }
    }

    /// <summary>Sets the specified code.</summary>
    /// <param name="carrierCode">The carrier code.</param>
    /// <param name="code">The code.</param>
    public static void Set(this CarrierCode carrierCode, string code) {
        carrierCode = FindCarrierCode(code);
    }

    /// <summary>Descriptions the specified handling unit.</summary>
    /// <param name="handlingUnit">The handling unit.</param>
    /// <returns></returns>
    public static string Description(this HandlingUnitType handlingUnit) {
        if (_listEnum[(int)handlingUnit] == null) { 
            _listEnum[(int)HandlingUnitType.AMM] = "Ammo Pack";
            _listEnum[(int)HandlingUnitType.BAG] = "Bag";
            _listEnum[(int)HandlingUnitType.BAL] = "Bale";
            _listEnum[(int)HandlingUnitType.BRG] = "Barge";
            _listEnum[(int)HandlingUnitType.BSK] = "Basket or Hamper";
            _listEnum[(int)HandlingUnitType.BBL] = "Barrel";
            _listEnum[(int)HandlingUnitType.BEM] = "Beam";
            _listEnum[(int)HandlingUnitType.BIC] = "Bing Chest";
            _listEnum[(int)HandlingUnitType.BIN] = "Bin";
            _listEnum[(int)HandlingUnitType.BOB] = "Bobbin";
            _listEnum[(int)HandlingUnitType.BOT] = "Bottle";
            _listEnum[(int)HandlingUnitType.BOX] = "Box";
            _listEnum[(int)HandlingUnitType.BXI] = "Box with inner container";
            _listEnum[(int)HandlingUnitType.BXT] = "Bucket";
            _listEnum[(int)HandlingUnitType.BLK] = "Bulk";
            _listEnum[(int)HandlingUnitType.BKG] = "Bulk Bag";
            _listEnum[(int)HandlingUnitType.BDL] = "Bundle";
            _listEnum[(int)HandlingUnitType.CAB] = "Cabinet";
            _listEnum[(int)HandlingUnitType.CAG] = "Cage";
            _listEnum[(int)HandlingUnitType.CAN] = "Can";
            _listEnum[(int)HandlingUnitType.CCS] = "Can Case";
            _listEnum[(int)HandlingUnitType.CBY] = "Carboy";
            _listEnum[(int)HandlingUnitType.CAR] = "Carrier";
            _listEnum[(int)HandlingUnitType.CTN] = "Carton";
            _listEnum[(int)HandlingUnitType.CAS] = "Case";
            _listEnum[(int)HandlingUnitType.CSK] = "Cask";
            _listEnum[(int)HandlingUnitType.CHE] = "Cheeses";
            _listEnum[(int)HandlingUnitType.CHS] = "Chest";
            _listEnum[(int)HandlingUnitType.COL] = "Coil";
            _listEnum[(int)HandlingUnitType.CON] = "Cones";
            _listEnum[(int)HandlingUnitType.CNX] = "Container Express";
            _listEnum[(int)HandlingUnitType.CNT] = "Container";
            _listEnum[(int)HandlingUnitType.CND] = "Container Commercial Highway Lift";
            _listEnum[(int)HandlingUnitType.CNB] = "Container MAC-ISO";
            _listEnum[(int)HandlingUnitType.CNC] = "Container Navy Cargo Transporter";
            _listEnum[(int)HandlingUnitType.CBC] = "Containers of Bulk Cargo";
            _listEnum[(int)HandlingUnitType.CRD] = "Cradle";
            _listEnum[(int)HandlingUnitType.CRT] = "Crate";
            _listEnum[(int)HandlingUnitType.CUB] = "Cube";
            _listEnum[(int)HandlingUnitType.CYL] = "Cylinder";
            _listEnum[(int)HandlingUnitType.DRK] = "Double-length Rack";
            _listEnum[(int)HandlingUnitType.DSK] = "Double-length Skid";
            _listEnum[(int)HandlingUnitType.DTB] = "Double-length Tote Bin";
            _listEnum[(int)HandlingUnitType.DRM] = "Drum";
            _listEnum[(int)HandlingUnitType.DBK] = "Dry Bulk";
            _listEnum[(int)HandlingUnitType.DUF] = "Duffle Bag";
            _listEnum[(int)HandlingUnitType.SKE] = "Elevating Skid or Lift Truck";
            _listEnum[(int)HandlingUnitType.CNE] = "Engine Container";
            _listEnum[(int)HandlingUnitType.ENV] = "Envelope";
            _listEnum[(int)HandlingUnitType.FIR] = "Firkin";
            _listEnum[(int)HandlingUnitType.FSK] = "Flask";
            _listEnum[(int)HandlingUnitType.FLO] = "Flo-bin";
            _listEnum[(int)HandlingUnitType.FWR] = "Forward Reel";
            _listEnum[(int)HandlingUnitType.FRM] = "Frame";
            _listEnum[(int)HandlingUnitType.GOH] = "Garments on Hangers";
            _listEnum[(int)HandlingUnitType.HRK] = "Half-Standard Rack";
            _listEnum[(int)HandlingUnitType.HTB] = "Half-Standard Tote Bin";
            _listEnum[(int)HandlingUnitType.HPR] = "Hamper";
            _listEnum[(int)HandlingUnitType.HED] = "Heads of Beef";
            _listEnum[(int)HandlingUnitType.HGH] = "Hogshead";
            _listEnum[(int)HandlingUnitType.HPT] = "Hopper Truck";
            _listEnum[(int)HandlingUnitType.CNA] = "Household Goods Containers";
            _listEnum[(int)HandlingUnitType.TLD] = "Intermodal Trailer";
            _listEnum[(int)HandlingUnitType.JAR] = "Jar";
            _listEnum[(int)HandlingUnitType.JUG] = "Jug";
            _listEnum[(int)HandlingUnitType.KEG] = "Keg";
            _listEnum[(int)HandlingUnitType.KIT] = "Kit";
            _listEnum[(int)HandlingUnitType.KRK] = "Knockdown Rack";
            _listEnum[(int)HandlingUnitType.KTB] = "Knockdown Tote Bin";
            _listEnum[(int)HandlingUnitType.LVN] = "Lift Van";
            _listEnum[(int)HandlingUnitType.LIF] = "Lifts";
            _listEnum[(int)HandlingUnitType.SBC] = "Liner Bag Dry";
            _listEnum[(int)HandlingUnitType.LBK] = "Liquid Bulk";
            _listEnum[(int)HandlingUnitType.FLX] = "Liquid Liner Bag";
            _listEnum[(int)HandlingUnitType.LOG] = "Log";
            _listEnum[(int)HandlingUnitType.LSE] = "Loose";
            _listEnum[(int)HandlingUnitType.LUG] = "Lug";
            _listEnum[(int)HandlingUnitType.MSV] = "Military Sealift Command Van";
            _listEnum[(int)HandlingUnitType.MLV] = "Military Van";
            _listEnum[(int)HandlingUnitType.MXD] = "Mixed Type Pack";
            _listEnum[(int)HandlingUnitType.CNF] = "Multiwall Container Secured to Warehouse Pallet";
            _listEnum[(int)HandlingUnitType.MRP] = "Multi-Roll Pack";
            _listEnum[(int)HandlingUnitType.NOL] = "Noil";
            _listEnum[(int)HandlingUnitType.HRB] = "On Hanger or Rack in Boxes";
            _listEnum[(int)HandlingUnitType.WHE] = "On Own Wheel";
            _listEnum[(int)HandlingUnitType.OVW] = "Overwrap";
            _listEnum[(int)HandlingUnitType.PKG] = "Package";
            _listEnum[(int)HandlingUnitType.PCK] = "Packed";
            _listEnum[(int)HandlingUnitType.PAL] = "Pail";
            _listEnum[(int)HandlingUnitType.PLS] = "Pails";
            _listEnum[(int)HandlingUnitType.PLT] = "Pallet";
            _listEnum[(int)HandlingUnitType.PCS] = "Pieces";
            _listEnum[(int)HandlingUnitType.PIR] = "Pims";
            _listEnum[(int)HandlingUnitType.PLN] = "Pipeline";
            _listEnum[(int)HandlingUnitType.PRK] = "Pipe Rack";
            _listEnum[(int)HandlingUnitType.PLF] = "Platform";
            _listEnum[(int)HandlingUnitType.POV] = "Private Vehicle";
            _listEnum[(int)HandlingUnitType.QTR] = "Quater of Beef";
            _listEnum[(int)HandlingUnitType.RCK] = "Rack";
            _listEnum[(int)HandlingUnitType.CLD] = "Rail Car Load";
            _listEnum[(int)HandlingUnitType.REL] = "Reel";
            _listEnum[(int)HandlingUnitType.RVR] = "Reverse Reel";
            _listEnum[(int)HandlingUnitType.ROL] = "Roll";
            _listEnum[(int)HandlingUnitType.SAK] = "Sack";
            _listEnum[(int)HandlingUnitType.TSS] = "Salesmen Sample Trunk";
            _listEnum[(int)HandlingUnitType.SVN] = "Sea Van";
            _listEnum[(int)HandlingUnitType.RAL] = "Semiconductor Rail";
            _listEnum[(int)HandlingUnitType.SHT] = "Sheet";
            _listEnum[(int)HandlingUnitType.SHK] = "Shook";
            _listEnum[(int)HandlingUnitType.SID] = "Side of Beef";
            _listEnum[(int)HandlingUnitType.SKD] = "Skid";
            _listEnum[(int)HandlingUnitType.SLV] = "Sleeve";
            _listEnum[(int)HandlingUnitType.SLP] = "Slip Sheet";
            _listEnum[(int)HandlingUnitType.SPI] = "Spin Cylinders";
            _listEnum[(int)HandlingUnitType.SPL] = "Spool";
            _listEnum[(int)HandlingUnitType.SCS] = "Suitcase";
            _listEnum[(int)HandlingUnitType.TNK] = "Tank";
            _listEnum[(int)HandlingUnitType.TKR] = "Tank Car";
            _listEnum[(int)HandlingUnitType.TKT] = "Tank Truck";
            _listEnum[(int)HandlingUnitType.TRC] = "Tierce";
            _listEnum[(int)HandlingUnitType.TBN] = "Tote Bin";
            _listEnum[(int)HandlingUnitType.TTC] = "Tote Can";
            _listEnum[(int)HandlingUnitType.TRY] = "Tray";
            _listEnum[(int)HandlingUnitType.TRI] = "Triwall Box";
            _listEnum[(int)HandlingUnitType.TRU] = "Truck";
            _listEnum[(int)HandlingUnitType.TRK] = "Trunk or Chest";
            _listEnum[(int)HandlingUnitType.TUB] = "Tub";
            _listEnum[(int)HandlingUnitType.TBE] = "Tube";
            _listEnum[(int)HandlingUnitType.UNP] = "Unpacked";
            _listEnum[(int)HandlingUnitType.UNT] = "Unit";
            _listEnum[(int)HandlingUnitType.VPK] = "Van Pack";
            _listEnum[(int)HandlingUnitType.VEH] = "Vehicle";
            _listEnum[(int)HandlingUnitType.WLC] = "Wheeled Carrier";
            _listEnum[(int)HandlingUnitType.WRP] = "Wrapped";
        }

        return _listEnum[(int)handlingUnit];
    }

    /// <summary>Codes the specified handling unit.</summary>
    /// <param name="handlingUnit">The handling unit.</param>
    /// <returns></returns>
    public static string Code(this HandlingUnitType handlingUnit) {
        return handlingUnit.ToString();
    }

    /// <summary>Finds the type of the handling unit.</summary>
    /// <param name="code">The code.</param>
    /// <returns></returns>
    public static HandlingUnitType? FindHandlingUnitType(string code) {
        try {
            return Enum.Parse<HandlingUnitType>(code);
        } catch {
            return null;
        }
    }

    /// <summary>Sets the specified code.</summary>
    /// <param name="handlingUnit">The handling unit.</param>
    /// <param name="code">The code.</param>
    public static void Set(this HandlingUnitType handlingUnit, string code) {
        HandlingUnitType? val = FindHandlingUnitType(code);
        handlingUnit = val ?? handlingUnit;
    }

    /// <summary>Descriptions the specified code.</summary>
    /// <param name="freightClass">The code.</param>
    /// <returns></returns>
    public static string Description(this FreightClassCode freightClass) {
        if (_listEnum[(int)freightClass] == null) { 
            _listEnum[(int)FreightClassCode.FREIGHT_CLASS_50] = "50";
            _listEnum[(int)FreightClassCode.FREIGHT_CLASS_55] =  "55";
            _listEnum[(int)FreightClassCode.FREIGHT_CLASS_60] =  "60";
            _listEnum[(int)FreightClassCode.FREIGHT_CLASS_65] =  "65";
            _listEnum[(int)FreightClassCode.FREIGHT_CLASS_70] = "70";
            _listEnum[(int)FreightClassCode.FREIGHT_CLASS_77_5] = "77.5";
            _listEnum[(int)FreightClassCode.FREIGHT_CLASS_85] = "85";
            _listEnum[(int)FreightClassCode.FREIGHT_CLASS_92_5] = "92.5";
            _listEnum[(int)FreightClassCode.FREIGHT_CLASS_100] = "100";
            _listEnum[(int)FreightClassCode.FREIGHT_CLASS_110] = "110";
            _listEnum[(int)FreightClassCode.FREIGHT_CLASS_125] = "125";
            _listEnum[(int)FreightClassCode.FREIGHT_CLASS_150] = "150";
            _listEnum[(int)FreightClassCode.FREIGHT_CLASS_175] = "175";
            _listEnum[(int)FreightClassCode.FREIGHT_CLASS_200] = "200";
            _listEnum[(int)FreightClassCode.FREIGHT_CLASS_250] = "250";
            _listEnum[(int)FreightClassCode.FREIGHT_CLASS_300] = "300";
            _listEnum[(int)FreightClassCode.FREIGHT_CLASS_400] = "400";
            _listEnum[(int)FreightClassCode.FREIGHT_CLASS_500] = "500";
        }

        return _listEnum[(int)freightClass];
    }

    /// <summary>Codes the specified freight class.</summary>
    /// <param name="freightClass">The freight class.</param>
    /// <returns></returns>
    public static string Code(this FreightClassCode freightClass) {
        return freightClass.Description();
    }

    /// <summary>Finds the freight class code.</summary>
    /// <param name="code">The code.</param>
    /// <returns></returns>
    public static FreightClassCode? FindFreightClassCode(string code) {
        switch (code) {
            case "50": return FreightClassCode.FREIGHT_CLASS_50;
            case "55": return FreightClassCode.FREIGHT_CLASS_55;
            case "60": return FreightClassCode.FREIGHT_CLASS_60;
            case "65": return FreightClassCode.FREIGHT_CLASS_65;
            case "70": return FreightClassCode.FREIGHT_CLASS_70;
            case "77.5": return FreightClassCode.FREIGHT_CLASS_77_5;
            case "85": return FreightClassCode.FREIGHT_CLASS_85;
            case "92.5": return FreightClassCode.FREIGHT_CLASS_92_5;
            case "100": return FreightClassCode.FREIGHT_CLASS_100;
            case "110": return FreightClassCode.FREIGHT_CLASS_110;
            case "125": return FreightClassCode.FREIGHT_CLASS_125;
            case "150": return FreightClassCode.FREIGHT_CLASS_150;
            case "175": return FreightClassCode.FREIGHT_CLASS_175;
            case "200": return FreightClassCode.FREIGHT_CLASS_200;
            case "250": return FreightClassCode.FREIGHT_CLASS_250;
            case "300": return FreightClassCode.FREIGHT_CLASS_300;
            case "400": return FreightClassCode.FREIGHT_CLASS_400;
            case "500": return FreightClassCode.FREIGHT_CLASS_500;
        }

        return null;
    }

    /// <summary>Sets the specified code.</summary>
    /// <param name="freightClass">The freight class.</param>
    /// <param name="code">The code.</param>
    public static void Set(this FreightClassCode freightClass, string code) {
        FreightClassCode? val = FindFreightClassCode(code);
        freightClass = val ?? freightClass;
    }

    /// <summary>Descriptions the specified code.</summary>
    /// <param name="hazardCode">The Hazardous Code.</param>
    /// <returns></returns>
    public static string Description(this HazardousClassCode hazardCode) {
        if (_listEnum[(int)hazardCode] == null) { 
            _listEnum[(int)HazardousClassCode.HAZ_CLASS_CODE_1_4B] = "Explosive 1.4B";
            _listEnum[(int)HazardousClassCode.HAZ_CLASS_CODE_1_4C] = "Explosive 1.4C";
            _listEnum[(int)HazardousClassCode.HAZ_CLASS_CODE_1_4D] = "Explosive 1.4D";
            _listEnum[(int)HazardousClassCode.HAZ_CLASS_CODE_1_4E] = "Explosive 1.4E";
            _listEnum[(int)HazardousClassCode.HAZ_CLASS_CODE_1_4F] = "Explosive 1.4F";
            _listEnum[(int)HazardousClassCode.HAZ_CLASS_CODE_1_4G] = "Explosive 1.4G";
            _listEnum[(int)HazardousClassCode.HAZ_CLASS_CODE_1_4S] = "Explosive 1.4S";
            _listEnum[(int)HazardousClassCode.HAZ_CLASS_CODE_1_5D] = "Blasting Agent";
            _listEnum[(int)HazardousClassCode.HAZ_CLASS_CODE_1_6N] = "Insensitive Detonating Substance";
            _listEnum[(int)HazardousClassCode.HAZ_CLASS_CODE_2_1] = "Flammable Gas";
            _listEnum[(int)HazardousClassCode.HAZ_CLASS_CODE_2_2] = "Non-Flammable Gas";
            _listEnum[(int)HazardousClassCode.HAZ_CLASS_CODE_2_3] = "Poisonous Gas";
            _listEnum[(int)HazardousClassCode.HAZ_CLASS_CODE_3] = "Flammable Liquid";
            _listEnum[(int)HazardousClassCode.HAZ_CLASS_CODE_4_1] = "Flammable Solid";
            _listEnum[(int)HazardousClassCode.HAZ_CLASS_CODE_4_2] = "Spontaneously Combustible Material";
            _listEnum[(int)HazardousClassCode.HAZ_CLASS_CODE_4_3] = "Dangerous When Wet";
            _listEnum[(int)HazardousClassCode.HAZ_CLASS_CODE_5_1] = "Oxidizer";
            _listEnum[(int)HazardousClassCode.HAZ_CLASS_CODE_5_2] = "Organic Peroxide";
            _listEnum[(int)HazardousClassCode.HAZ_CLASS_CODE_6_1] = "Poisonous Material";
            _listEnum[(int)HazardousClassCode.HAZ_CLASS_CODE_7] = "Radioactive Material";
            _listEnum[(int)HazardousClassCode.HAZ_CLASS_CODE_8] = "Corrosive Material";
            _listEnum[(int)HazardousClassCode.HAZ_CLASS_CODE_9] = "Misc. Hazardous Material";
            _listEnum[(int)HazardousClassCode.COMBUSTIBLE_LIQUID] = "Compustible Liquid";
        }

        return _listEnum[(int)hazardCode];
    }

    /// <summary>Determines whether hazardous class code is a sub risk</summary>
    /// <param name="code">The code.</param>
    /// <returns><c>true</c> if is sub risk; otherwise, <c>false</c>.</returns>
    public static bool IsSubRisk(this HazardousClassCode code) {
        switch (code) {
            case HazardousClassCode.HAZ_CLASS_CODE_2_1:
            case HazardousClassCode.HAZ_CLASS_CODE_2_2:
            case HazardousClassCode.HAZ_CLASS_CODE_2_3:
            case HazardousClassCode.HAZ_CLASS_CODE_3:
            case HazardousClassCode.HAZ_CLASS_CODE_4_1:
            case HazardousClassCode.HAZ_CLASS_CODE_4_2:
            case HazardousClassCode.HAZ_CLASS_CODE_4_3:
            case HazardousClassCode.HAZ_CLASS_CODE_5_1:
            case HazardousClassCode.HAZ_CLASS_CODE_5_2:
            case HazardousClassCode.HAZ_CLASS_CODE_6_1:
            case HazardousClassCode.HAZ_CLASS_CODE_8:
                return true;
        }

        return false;
    }

    /// <summary>Codes the specified hazardous class.</summary>
    /// <param name="hazardousClass">The hazardous class.</param>
    /// <returns></returns>
    public static string Code(this HazardousClassCode hazardousClass) {
        if (_listEnum[_codeOffset + (int)hazardousClass] == null) {
            _listEnum[_codeOffset + (int)HazardousClassCode.HAZ_CLASS_CODE_1_4B] = "1.4B";
            _listEnum[_codeOffset + (int)HazardousClassCode.HAZ_CLASS_CODE_1_4C] = "1.4C";
            _listEnum[_codeOffset + (int)HazardousClassCode.HAZ_CLASS_CODE_1_4D] = "1.4D";
            _listEnum[_codeOffset + (int)HazardousClassCode.HAZ_CLASS_CODE_1_4E] = "1.4E";
            _listEnum[_codeOffset + (int)HazardousClassCode.HAZ_CLASS_CODE_1_4F] = "1.4F";
            _listEnum[_codeOffset + (int)HazardousClassCode.HAZ_CLASS_CODE_1_4G] = "1.4G";
            _listEnum[_codeOffset + (int)HazardousClassCode.HAZ_CLASS_CODE_1_4S] = "1.4S";
            _listEnum[_codeOffset + (int)HazardousClassCode.HAZ_CLASS_CODE_1_5D] = "1.5D";
            _listEnum[_codeOffset + (int)HazardousClassCode.HAZ_CLASS_CODE_1_6N] = "1.6N";
            _listEnum[_codeOffset + (int)HazardousClassCode.HAZ_CLASS_CODE_2_1] = "2.1";
            _listEnum[_codeOffset + (int)HazardousClassCode.HAZ_CLASS_CODE_2_2] = "2.2";
            _listEnum[_codeOffset + (int)HazardousClassCode.HAZ_CLASS_CODE_2_3] = "2.3";
            _listEnum[_codeOffset + (int)HazardousClassCode.HAZ_CLASS_CODE_3] = "3";
            _listEnum[_codeOffset + (int)HazardousClassCode.HAZ_CLASS_CODE_4_1] = "4.1";
            _listEnum[_codeOffset + (int)HazardousClassCode.HAZ_CLASS_CODE_4_2] = "4.2";
            _listEnum[_codeOffset + (int)HazardousClassCode.HAZ_CLASS_CODE_4_3] = "4.3";
            _listEnum[_codeOffset + (int)HazardousClassCode.HAZ_CLASS_CODE_5_1] = "5.1";
            _listEnum[_codeOffset + (int)HazardousClassCode.HAZ_CLASS_CODE_5_2] = "5.2";
            _listEnum[_codeOffset + (int)HazardousClassCode.HAZ_CLASS_CODE_6_1] = "6.1";
            _listEnum[_codeOffset + (int)HazardousClassCode.HAZ_CLASS_CODE_7] = "7";
            _listEnum[_codeOffset + (int)HazardousClassCode.HAZ_CLASS_CODE_8] = "8";
            _listEnum[_codeOffset + (int)HazardousClassCode.HAZ_CLASS_CODE_9] = "9";
            _listEnum[_codeOffset + (int)HazardousClassCode.COMBUSTIBLE_LIQUID] = "CL";
        }

        return _listEnum[_codeOffset + (int)hazardousClass];
    }

    /// <summary>Finds the hazardous class code.</summary>
    /// <param name="code">The code.</param>
    /// <returns></returns>
    public static HazardousClassCode? FindHazardousClassCode(string code) {
        switch (code.ToUpper()) {
            case "Explosive 1.4B":
            case "1.4B": return HazardousClassCode.HAZ_CLASS_CODE_1_4B;
            case "Explosive 1.4C":
            case "1.4C": return HazardousClassCode.HAZ_CLASS_CODE_1_4C;
            case "Explosive 1.4D":
            case "1.4D": return HazardousClassCode.HAZ_CLASS_CODE_1_4D;
            case "Explosive 1.4E":
            case "1.4E": return HazardousClassCode.HAZ_CLASS_CODE_1_4E;
            case "Explosive 1.4F":
            case "1.4F": return HazardousClassCode.HAZ_CLASS_CODE_1_4F;
            case "Explosive 1.4G":
            case "1.4G": return HazardousClassCode.HAZ_CLASS_CODE_1_4G;
            case "Explosive 1.4S":
            case "1.4S": return HazardousClassCode.HAZ_CLASS_CODE_1_4S;
            case "Blasting Agent":
            case "1.5D": return HazardousClassCode.HAZ_CLASS_CODE_1_5D;
            case "Insensitive Detonating Substance":
            case "1.6N": return HazardousClassCode.HAZ_CLASS_CODE_1_6N;
            case "Flammable Gas":
            case "2.1": return HazardousClassCode.HAZ_CLASS_CODE_2_1;
            case "Non-Flammable Gas":
            case "2.2": return HazardousClassCode.HAZ_CLASS_CODE_2_2;
            case "Poisonous Gas":
            case "2.3": return HazardousClassCode.HAZ_CLASS_CODE_2_3;
            case "Flammable Liquid":
            case "3": return HazardousClassCode.HAZ_CLASS_CODE_3;
            case "Flammable Solid":
            case "4.1": return HazardousClassCode.HAZ_CLASS_CODE_4_1;
            case "Spontaneously Combustible Material":
            case "4.2": return HazardousClassCode.HAZ_CLASS_CODE_4_2;
            case "Dangerous When Wet":
            case "4.3": return HazardousClassCode.HAZ_CLASS_CODE_4_3;
            case "Oxidizer":
            case "5.1": return HazardousClassCode.HAZ_CLASS_CODE_5_1;
            case "Organic Peroxide":
            case "5.2": return HazardousClassCode.HAZ_CLASS_CODE_5_2;
            case "Poisonous Material":
            case "6.1": return HazardousClassCode.HAZ_CLASS_CODE_6_1;
            case "Radioactive Material":
            case "7": return HazardousClassCode.HAZ_CLASS_CODE_7;
            case "Corrosive Material":
            case "8": return HazardousClassCode.HAZ_CLASS_CODE_8;
            case "Misc. Hazardous Material":
            case "9": return HazardousClassCode.HAZ_CLASS_CODE_9;
            case "COMBUSTIBLE_LIQUID":
            case "CL": return HazardousClassCode.COMBUSTIBLE_LIQUID;
        }

        return null;
    }

    /// <summary>Sets the specified code.</summary>
    /// <param name="hazardousClass">The hazardous class.</param>
    /// <param name="code">The code.</param>
    public static void Set(this HazardousClassCode hazardousClass, string code) {
        HazardousClassCode? val = FindHazardousClassCode(code);
        hazardousClass = val ?? hazardousClass;
    }


    /// <summary>Descriptions the specified packing group.</summary>
    /// <param name="packingGroup">The packing group.</param>
    /// <returns>Description</returns>
    public static string Description(this PackingGroupCode packingGroup) {
        if (_listEnum[(int)packingGroup] == null) {         
            _listEnum[(int)PackingGroupCode.I] = "High danger";
            _listEnum[(int)PackingGroupCode.II] = "Medium danger";
            _listEnum[(int)PackingGroupCode.III] = "Low danger";
        }

        return _listEnum[(int)packingGroup];
    }

    /// <summary>Codes the specified packing group.</summary>
    /// <param name="packingGroup">The packing group.</param>
    /// <returns></returns>
    public static string Code(this PackingGroupCode packingGroup) {
        return packingGroup.ToString();
    }

    /// <summary>Finds the packing group code.</summary>
    /// <param name="code">The code.</param>
    /// <returns></returns>
    public static PackingGroupCode? FindPackingGroupCode(string code) {
        try {
            return Enum.Parse<PackingGroupCode>(code);
        } catch {
            return null;
        }
    }

    /// <summary>Sets the specified code.</summary>
    /// <param name="packingGroup">The packing group.</param>
    /// <param name="code">The code.</param>
    public static void Set(this PackingGroupCode packingGroup, string code) {
        PackingGroupCode? val = FindPackingGroupCode(code);
        packingGroup = val ?? packingGroup;
    }

    /// <summary>Descriptions the specified regulation code.</summary>
    /// <param name="reg">The reg.</param>
    /// <returns>Description</returns>
    public static string Description(this RegulationCode reg) {
        if (_listEnum[(int)reg] == null) {
            _listEnum[(int)RegulationCode.DOT] = "DOT";
            _listEnum[(int)RegulationCode.ICAO] = "ICAO";
            _listEnum[(int)RegulationCode.IMDG] = "IMDG";
            _listEnum[(int)RegulationCode.TDG] = "TDG";
        }

        return _listEnum[(int)reg];
    }

    /// <summary>Codes the specified reg.</summary>
    /// <param name="reg">The reg.</param>
    /// <returns></returns>
    public static string Code(this RegulationCode reg) {
        if (_listEnum[_codeOffset + (int)reg] == null) {
            _listEnum[_codeOffset + (int)RegulationCode.DOT] = "S";
            _listEnum[_codeOffset + (int)RegulationCode.ICAO] = "C";
            _listEnum[_codeOffset + (int)RegulationCode.IMDG] = "M";
            _listEnum[_codeOffset + (int)RegulationCode.TDG] = "T";
        }

        return _listEnum[_codeOffset + (int)reg];
    }

    /// <summary>Finds the regulation code.</summary>
    /// <param name="code">The code.</param>
    /// <returns></returns>
    public static RegulationCode? FindRegulationCode(string code) {
        switch (code.ToUpper()) {
            case "DOT":
            case "S": return RegulationCode.DOT;
            case "ICAO":
            case "C": return RegulationCode.ICAO;
            case "IMDG":
            case "M": return RegulationCode.IMDG;
            case "TDG":
            case "T": return RegulationCode.TDG;
        }

        return null;
    }

    /// <summary>Sets the specified code.</summary>
    /// <param name="reg">The reg.</param>
    /// <param name="code">The code.</param>
    public static void Set(this RegulationCode reg, string code) {
        RegulationCode? val = FindRegulationCode(code);
        reg = val ?? reg;
    }

    /// <summary>Descriptions the specified zone.</summary>
    /// <param name="zone">The zone.</param>
    /// <returns>Description</returns>
    public static string Description(this InhalationHazardZone zone) {
        return zone.ToString();
    }

    /// <summary>Codes the specified zone.</summary>
    /// <param name="zone">The zone.</param>
    /// <returns></returns>
    public static string Code(this InhalationHazardZone zone) {
        return zone.ToString();
    }

    /// <summary>Finds the inhalation hazard zone.</summary>
    /// <param name="code">The code.</param>
    /// <returns></returns>
    public static InhalationHazardZone? FindInhalationHazardZone(string code) {
        try {
            return Enum.Parse<InhalationHazardZone>(code);
        } catch {
            return null;
        }
    }

    /// <summary>Sets the specified code.</summary>
    /// <param name="zone">The zone.</param>
    /// <param name="code">The code.</param>
    public static void Set(this InhalationHazardZone zone, string code) {
        InhalationHazardZone? val = FindInhalationHazardZone(code);
        zone = val ?? zone;
    }

    /// <summary>Descriptions the specified service level.</summary>
    /// <param name="serviceLevel">The service level.</param>
    /// <returns></returns>
    public static string Description(this ServiceLevelCode serviceLevel) {
        if (_listEnum[(int)serviceLevel] == null) { 
            _listEnum[(int)ServiceLevelCode.STANDARD] = "Standard";
            _listEnum[(int)ServiceLevelCode.GUARANTEED] = "Guaranteed";
            _listEnum[(int)ServiceLevelCode.TIME_CRITICAL] = "Time Critical";
            _listEnum[(int)ServiceLevelCode.QUOTE] = "Quote";
            _listEnum[(int)ServiceLevelCode.SPOT_VOLUME] = "Spot Volume";
        }

        return string.Empty;
    }

    /// <summary>Codes the specified service level.</summary>
    /// <param name="serviceLevel">The service level.</param>
    /// <returns></returns>
    public static string Code(this ServiceLevelCode serviceLevel) {
        return serviceLevel.ToString();
    }

    /// <summary>Finds the service level code.</summary>
    /// <param name="code">The code.</param>
    /// <returns></returns>
    public static ServiceLevelCode? FindServiceLevelCode(string code) {
        try {
            return Enum.Parse<ServiceLevelCode>(code);
        } catch {
            return null;
        }
    }

    /// <summary>Sets the specified code.</summary>
    /// <param name="serviceLevel">The service level.</param>
    /// <param name="code">The code.</param>
    public static void Set(this ServiceLevelCode serviceLevel, string code) {
        ServiceLevelCode? val = FindServiceLevelCode(code);
        serviceLevel = val ?? serviceLevel;
    }

    /// <summary>Descriptions the specified service type.</summary>
    /// <param name="serviceType">Type of the service.</param>
    /// <returns></returns>
    public static string Description(this ServiceTypeCode serviceType) {
        if (_listEnum[(int)serviceType] == null) { 
            _listEnum[(int)ServiceTypeCode.NOON] = "by Noon";
            _listEnum[(int)ServiceTypeCode.PM5] = "by 5 PM (17:00)";
            _listEnum[(int)ServiceTypeCode.MULTIDAY] = "Multiday Window";
            _listEnum[(int)ServiceTypeCode.HOUR] = "Hour Window";
        }

        return _listEnum[(int)serviceType];
    }

    /// <summary>Codes the specified service type.</summary>
    /// <param name="serviceType">Type of the service.</param>
    /// <returns></returns>
    public static string Code(this ServiceTypeCode serviceType) {
        return serviceType.ToString();
    }

    /// <summary>Finds the service type code.</summary>
    /// <param name="code">The code.</param>
    /// <returns></returns>
    public static ServiceTypeCode? FindServiceTypeCode(string code) {
        try {
            return Enum.Parse<ServiceTypeCode>(code);
        } catch {
            return null;
        }
    }

    /// <summary>Sets the specified code.</summary>
    /// <param name="serviceType">Type of the service.</param>
    /// <param name="code">The code.</param>
    public static void Set(this ServiceTypeCode serviceType, string code) {
        ServiceTypeCode? val = FindServiceTypeCode(code);
        serviceType = val ?? serviceType;
    }

    /// <summary>Descriptions the specified reference number.</summary>
    /// <param name="referenceNumber">The reference number.</param>
    /// <returns></returns>
    public static string Description(this ReferenceNumberType referenceNumber) {
        if (_listEnum[(int)referenceNumber] == null) { 
            _listEnum[(int)ReferenceNumberType.BOL_M_NUMBER] = "Bill of Lading Number";
            _listEnum[(int)ReferenceNumberType.BOL_NUMBER] = "Bill of Lading Number";
            _listEnum[(int)ReferenceNumberType.BOOKING_NUMBER] = "Booking Number";
            _listEnum[(int)ReferenceNumberType.CARTON_NUMBER] = "Carton Number";
            _listEnum[(int)ReferenceNumberType.CONTRACT_NUMBER] = "Contract Number";
            _listEnum[(int)ReferenceNumberType.CUSTOMER_NUMBER] = "Customer Number";
            _listEnum[(int)ReferenceNumberType.CUSTOERM_ORDER_NUMBER] = "Customer Order Number";
            _listEnum[(int)ReferenceNumberType.DELIVERY_NUMBER] = "Delivery Number";
            _listEnum[(int)ReferenceNumberType.FACTURA_NUMBER] = "Factura Number";
            _listEnum[(int)ReferenceNumberType.GENERAL_REF_NUMBER] = "General Ref Number";
            _listEnum[(int)ReferenceNumberType.LOADING_NUMBER] = "Loading Number";
            _listEnum[(int)ReferenceNumberType.MANIFEST_NUMBER] = "Manifest Number";
            _listEnum[(int)ReferenceNumberType.PEDIMENTO_NUMBER] = "Pedimento Number";
            _listEnum[(int)ReferenceNumberType.PRO_NUMBER] = "Pro Number";
            _listEnum[(int)ReferenceNumberType.PROMOTIONAL_DEAL] = "Promotional Deal";
            _listEnum[(int)ReferenceNumberType.PURCHASE_ORDER_NUMBER] = "Purchase Order Number";
            _listEnum[(int)ReferenceNumberType.QUOTE_NUMBER] = "Quote Number";
            _listEnum[(int)ReferenceNumberType.REQUESTED_ARRIVAL_DATE] = "Requested Arrival Date";
            _listEnum[(int)ReferenceNumberType.RETURN_AUTHORIZATION] = "Return Authorization";
            _listEnum[(int)ReferenceNumberType.SEAL_NUMBER] = "Seal Number";
            _listEnum[(int)ReferenceNumberType.SELLERS_INVOICE_NUMBER] = "Seller's Invoice Number";
            _listEnum[(int)ReferenceNumberType.SHIPPERS_IDENTIFYING_NUMBER] = "Shipper's Identifying Number";
            _listEnum[(int)ReferenceNumberType.TRANSPORTATION_CONTORL_NUMBER] = "Transportation Control Number";
        }

        return _listEnum[(int)referenceNumber];
    }

    /// <summary>Codes the specified reference number.</summary>
    /// <param name="referenceNumber">The reference number.</param>
    /// <returns></returns>
    public static string Code(this ReferenceNumberType referenceNumber) {
        return referenceNumber.ToString();
    }

    /// <summary>Finds the type of the reference number.</summary>
    /// <param name="code">The code.</param>
    /// <returns></returns>
    public static ReferenceNumberType? FindReferenceNumberType(string code) {
        try {
            return Enum.Parse<ReferenceNumberType>(code);
        } catch {
            return null;
        }
    }

    /// <summary>Sets the specified code.</summary>
    /// <param name="referenceNumber">The reference number.</param>
    /// <param name="code">The code.</param>
    public static void Set(this ReferenceNumberType referenceNumber, string code) {
        ReferenceNumberType? val = FindReferenceNumberType(code);
        referenceNumber = val ?? referenceNumber;
    }

    /// <summary>Descriptions the specified deliver to.</summary>
    /// <param name="deliverTo">The deliver to.</param>
    /// <returns></returns>
    public static string Description(this DeliverToCode deliverTo) {
        if (_listEnum[(int)deliverTo] == null) {
            _listEnum[(int)DeliverToCode.A] = "Advance warehouse";
            _listEnum[(int)DeliverToCode.S] = "Show Site";
        }

        return _listEnum[(int)deliverTo];
    }

    /// <summary>Codes the specified deliver to.</summary>
    /// <param name="deliverTo">The deliver to.</param>
    /// <returns></returns>
    public static string Code(this DeliverToCode deliverTo) {
        return deliverTo.ToString();
    }

    /// <summary>Finds the deliver to code.</summary>
    /// <param name="code">The code.</param>
    /// <returns></returns>
    public static DeliverToCode? FindDeliverToCode(string code) { 
        try {
            return Enum.Parse<DeliverToCode>(code);
        } catch {
            return null;
        }
    }

    /// <summary>Sets the specified code.</summary>
    /// <param name="deliverTo">The deliver to.</param>
    /// <param name="code">The code.</param>
    public static void Set(this DeliverToCode deliverTo, string code) {
        DeliverToCode? val = FindDeliverToCode(code);
        deliverTo = val ?? deliverTo;
    }
}
