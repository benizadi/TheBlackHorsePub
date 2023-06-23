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


public class Address : Entity
{
    public Guid AddressId { get; set; }
    public string FirstLineOfAddress { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public string Phone { get; set; }
    public string Fax { get; set; }

    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; }
}
 
public class Order : Entity
{
    public Guid OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime RequiredDate { get; set; }
    public DateTime ShipDate { get; set; }
    
    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; }
}

public abstract class Entity
{
    public Guid Id { get; }

    protected Entity(Guid id)
    {
        Id = id;
    }

    protected Entity() : this(Guid.NewGuid())
    {
        
    }
}
 
 
// public class Employee : Entity
// {
//     public Guid EmployeeId { get; set; }
//     public string FirstName { get; set; }
//     public string LastName { get; set; }
// }


//
// public class OrderDetail : Entity
// {
//     public decimal UnitPrice { get; set; }
//     public int Quantity { get; set; }
//     
//     //has orders
//     //has products
// }
//
// public class Product
// {
//     public Guid ProductId { get; set; }
//     public string ProductName { get; set; }
//     public decimal UnitPrice { get; set; }
// }

