namespace DataAccess.Domain;

public class Producer : Entity
{
    public Guid ProducerId { get; set; }
    public string BrandName { get; set; }

    public ICollection<ProducerProduct> ProducerProducts { get; set; }
}