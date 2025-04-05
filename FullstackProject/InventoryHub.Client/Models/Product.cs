namespace InventoryHub.Client.Models
{
    public class Product
    {
        public int Id { get; set; } // Unique identifier
        public string Name { get; set; } // Name of the product
        public int Quantity { get; set; } // Quantity available
        public decimal Price { get; set; } // Price of the product
    }
}