
namespace WarehouseSystem
{
    public interface IStoreObject
    {
        string CatalogueNumber { get; set; }

        string Manufacturer { get; set; }

        string Model { get; set; }

        string Description { get; set; }

        int Quantity { get; set; }

        Branch Category { get; set; }

        decimal Price { get; set; }

    }
}
