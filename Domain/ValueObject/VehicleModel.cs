using FleetInfoHub.Domain;

namespace FleetInfoHub.Domain.ValueObjects;

public class VehicleModel : ValueObject
{
    public string Brand { get; }
    public string Name { get; }

    public VehicleModel(string brand, string name)
    {
        Brand = brand;
        Name = name;
    }

    public VehicleModel() { }

    public static VehicleModel Create(string brand, string name)
    {
        return new VehicleModel(brand, name);
    }
}
