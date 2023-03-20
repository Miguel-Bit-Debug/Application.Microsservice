namespace Domain.Models
{
    public class Product : Entity
    {
        public Product(string productName, string description)
        {
            ProductName = productName;
            Description = description;
        }

        public string ProductName { get; set; }
        public string Description { get; set; }
    }
}
