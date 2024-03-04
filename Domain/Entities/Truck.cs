using FleetInfoHub.Domain.Common;

namespace FleetInfoHub.Domain.Entities;

public sealed class Truck : Vehicle
{
    public string Renavam { get; private set; }
    public string Capacity { get; private set; }
    public int Axes { get; private set; }
    public int Chassi { get; private set; }
    public int Pallets { get; private set; }
    public DateTime Manufacturing { get; private set; }
    public Vehicle VehicleBase { get; private set; }

    public Truck(
        string renavam,
        string capacity,
        int axes,
        int chassi,
        int pallets,
        DateTime manufacturing,
        Vehicle vehicleBase
    )
    {
        Renavam = renavam;
        Capacity = capacity;
        Axes = axes;
        Chassi = chassi;
        Pallets = pallets;
        Manufacturing = manufacturing;
        VehicleBase = vehicleBase;
    }
}
