using System;
using System.Collections.Generic;

namespace CafeManager.DAL.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Position { get; set; }

    public DateOnly? HireDate { get; set; }

    public decimal? Salary { get; set; }

    public virtual Account EmployeeNavigation { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
