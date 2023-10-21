namespace PatternsExample.Builder.VehicleBuilderExample;

public abstract class CarBuilder
{
    public Car Car { get; init; }

    public abstract void BuildFrame();
    public abstract void BuildEngine();
    public abstract void BuildWheels();
    public abstract void BuildDoors();
}