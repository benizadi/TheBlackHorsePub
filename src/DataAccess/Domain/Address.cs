namespace DataAccess.Domain;

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