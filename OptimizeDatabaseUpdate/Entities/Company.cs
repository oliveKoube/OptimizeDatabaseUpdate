namespace OptimizeDatabaseUpdate.Entities;

public class Company
{
    public int Id { get; set; }
    
    public string Name { get; set; } = String.Empty;

    public DateTime? LastSalaryUpdateUtc { get; set; }
    
    public List<Employee> Employees { get; set; }
}