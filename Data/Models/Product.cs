namespace InventoryManagementSystem.Data.Models
{
    public class Product : BaseModel
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}
