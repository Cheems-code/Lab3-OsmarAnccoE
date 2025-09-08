﻿using System;
using System.Collections.Generic;

namespace Lab3_OsmarAnccoE.Models;

public partial class Recipe
{
    public Guid Id { get; set; }

    public Guid ProductId { get; set; }

    public Guid ResourceId { get; set; }

    public double Quantity { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual Resource Resource { get; set; } = null!;
}
