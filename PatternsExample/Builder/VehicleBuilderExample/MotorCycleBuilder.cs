namespace PatternsExample.Builder.VehicleBuilderExample;

public sealed class MotorCycleBuilder : CarBuilder
{
    public MotorCycleBuilder()
    {
        Car = new Car("MotorCycle");
    }
    
    public override void BuildFrame()
    {
        Car[CarPartKeys.Frame] = "MotorCycle frame";
    }

    public override void BuildEngine()
    {
        Car[CarPartKeys.Engine] = "500 cc";
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