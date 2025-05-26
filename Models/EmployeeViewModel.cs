namespace EmployeeApp.Models;

public class EmployeeViewModel
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Department { get; set; } = default!;
}