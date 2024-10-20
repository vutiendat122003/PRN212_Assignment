using System;
using System.Collections.Generic;

namespace CafeManager.DAL.Models;

public partial class Account
{
    public int AccountId { get; set; }

    public int? EmployeeId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Email { get; set; }

    public string Role { get; set; } = null!;

    public virtual Employee? Employee { get; set; }
}
