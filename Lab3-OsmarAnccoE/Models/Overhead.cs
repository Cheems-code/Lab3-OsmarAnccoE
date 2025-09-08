using System;
using System.Collections.Generic;

namespace Lab3_OsmarAnccoE.Models;

public partial class Overhead
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime Date { get; set; }

    public string Type { get; set; } = null!;

    public decimal Amount { get; set; }

    public string? Description { get; set; }

    public bool Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
