namespace Lab_7.Models;

public class EmployeeModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set; }
    
    // Transient property for selection
    public bool IsSelected { get; set; }
}
