namespace WebApi.Entities;

public class ServiceOptions {
    public ServiceLevelCode ServiceLevel { get; set; }
    public ServiceTypeCode ServiceType { get; set; }
    public WindowOptions Window { get; set; }
}