namespace DataAccess.Domain;

public class Employee : Entity
{
    public Guid EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}