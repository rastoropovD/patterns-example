namespace PatternsExample.Builder.VehicleBuilderExample;

public sealed class JeepBuilder : CarBuilder
{
    public JeepBuilder()
    {
        Car = new Car("Jeep");
    }
    
    public override void BuildFrame()
    {
        Car[CarPartKeys.Frame] = "Jeep frame";
    }

    public override void BuildEngine()
    {
        Car[CarPartKeys.Engine] = "2500 cc";
    }

    public override void BuildWheels()
    {
        Car[CarPartKeys.Wheels] = "4";
    }

    public override void BuildDoors()
    {
        Car[CarPartKeys.Doors] = "5";
    }
}