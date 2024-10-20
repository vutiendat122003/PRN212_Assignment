using System;
using System.Collections.Generic;

namespace CafeManager.DAL.Models;

public partial class Table
{
    public int TableId { get; set; }

    public int TableNumber { get; set; }

    public string? Location { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
