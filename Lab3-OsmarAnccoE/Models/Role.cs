﻿using System;
using System.Collections.Generic;

namespace Lab3_OsmarAnccoE.Models;

public partial class Role
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public bool Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<RolesPermission> RolesPermissions { get; set; } = new List<RolesPermission>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
