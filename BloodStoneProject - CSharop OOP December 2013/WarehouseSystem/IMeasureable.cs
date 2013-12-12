
namespace WarehouseSystem
{
    public interface IMeasureable
    {
        Dimensions Dimensions { get; set; }

        double Weight { get; set; }
    }
}
