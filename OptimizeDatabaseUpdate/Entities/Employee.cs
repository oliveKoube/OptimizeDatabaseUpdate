namespace OptimizeDatabaseUpdate.Entities;

public class Employee
{
    public int Id { get; set; }
    
    public string Name { get; set; } = String.Empty;
    
    public decimal Salary { get; set; }
    
    public int CompanyId { get; set; }
}