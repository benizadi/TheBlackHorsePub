 using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DataAccess.Domain;

public class Customer : Entity
{
    public Guid CustomerId { get; set; }
    public string CompanyName { get; set; }
    public string ContactName { get; set; }
    public string ContactTitle { get; set; }
    public Address Address { get; set; }
    public ICollection<Order> Orders { get; set; }
}