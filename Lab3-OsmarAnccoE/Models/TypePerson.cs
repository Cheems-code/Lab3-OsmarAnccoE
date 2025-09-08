using System;
using System.Collections.Generic;

namespace Lab3_OsmarAnccoE.Models;

public partial class TypePerson
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public double BasePrice { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<Entrance> Entrances { get; set; } = new List<Entrance>();
}
