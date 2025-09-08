﻿using System;
using System.Collections.Generic;

namespace Lab3_OsmarAnccoE.Models;

public partial class Place
{
    public Guid Id { get; set; }

    public Guid LocationId { get; set; }

    public string Name { get; set; } = null!;

    public string Area { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual ICollection<Rental> Rentals { get; set; } = new List<Rental>();
}
