namespace DataAccess.Domain;

public class Order : Entity
{
    public Guid OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime RequiredDate { get; set; }
    public DateTime ShipDate { get; set; }
    
    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; }
}