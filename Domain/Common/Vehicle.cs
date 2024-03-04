using FleetInfoHub.Domain.ValueObjects;

namespace FleetInfoHub.Domain.Common;

public class Vehicle : VehicleModel
{
    public string Plate { get; private set; }
    public VehicleModel Model { get; private set; }

    public Vehicle(string plate, VehicleModel vehicleModel)
    {
        Plate = plate;
        Model = vehicleModel;
    }

    public Vehicle() { }

    public static Vehicle Create(string plate, VehicleModel model)
    {
        return new(plate, model);
    }
}
