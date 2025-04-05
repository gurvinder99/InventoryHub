namespace InventoryHub.API.Models
{
    public class Product
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; } // Product Name
        public int Quantity { get; set; } // Quantity in Stock
        public decimal Price { get; set; } // Product Price
    }
}