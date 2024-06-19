using System.ComponentModel.DataAnnotations;

namespace Lab_7.Models;

public class EmployeeModel
{
    [Required]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Position { get; set; }
    [Required]
    public decimal Salary { get; set; }
    
    // Transient property for selection
    public bool IsSelected { get; set; }
}
