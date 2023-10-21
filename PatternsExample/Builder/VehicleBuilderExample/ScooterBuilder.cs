namespace PatternsExample.Builder.VehicleBuilderExample;

public sealed class ScooterBuilder : CarBuilder
{
    public ScooterBuilder()
    {
        Car = new Car("Scooter");
    }
    
    public override void BuildFrame()
    {
        Car[CarPartKeys.Frame] = "Scooter frame";
    }

    public override void BuildEngine()
    {
        Car[CarPartKeys.Engine] = "50 cc";
    }

    public override void BuildWheels()
    {
        Car[CarPartKeys.Wheels] = "2";
    }

    public override void BuildDoors()
    {
        Car[CarPartKeys.Doors] = "0";
    }
}