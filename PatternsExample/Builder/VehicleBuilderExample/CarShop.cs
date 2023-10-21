namespace PatternsExample.Builder.VehicleBuilderExample;

public interface ICarShop
{
    void Construct(CarBuilder builder);
}

public sealed class CarShop : ICarShop
{
    public void Construct(CarBuilder builder)
    {
        builder.BuildFrame();
        builder.BuildEngine();
        builder.BuildWheels();
        builder.BuildDoors();
    }
}