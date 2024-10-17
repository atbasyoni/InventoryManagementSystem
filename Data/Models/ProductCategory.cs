namespace InventoryManagementSystem.Data.Models
{
    public class ProductCategory : BaseModel
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
