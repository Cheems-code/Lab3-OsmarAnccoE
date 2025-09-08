using System;
using System.Collections.Generic;

namespace Lab3_OsmarAnccoE.Models;

public partial class Return
{
    public Guid Id { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? SalesId { get; set; }

    public string Reason { get; set; } = null!;

    public string? Observations { get; set; }

    public int Quantity { get; set; }

    public decimal Price { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual Product? Product { get; set; }

    public virtual Sale? Sales { get; set; }
}
