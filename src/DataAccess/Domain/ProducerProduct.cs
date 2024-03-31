namespace DataAccess.Domain;

public class ProducerProduct : Entity
{
    public Guid ProducerId { get; set; }
    public Producer Producer { get; set; }
    
    public Guid ProductId { get; set; }
    public Product Product { get; set; }
}