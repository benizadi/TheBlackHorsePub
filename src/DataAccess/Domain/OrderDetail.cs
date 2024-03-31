namespace DataAccess.Domain;

public class OrderDetail : Entity
{
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }
    
    //has orders
    //has products
}