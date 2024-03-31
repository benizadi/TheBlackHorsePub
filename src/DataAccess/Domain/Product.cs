namespace DataAccess.Domain;

public class Product : Entity
{
    public Guid ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; }

    public ICollection<ProducerProduct> ProducerProducts { get; set; }
}