using System;
using System.Collections.Generic;

namespace Lab3_OsmarAnccoE.Models;

public partial class Module
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<GeneralExpense> GeneralExpenseModules { get; set; } = new List<GeneralExpense>();

    public virtual ICollection<GeneralExpense> GeneralExpenseReports { get; set; } = new List<GeneralExpense>();

    public virtual ICollection<GeneralIncome> GeneralIncomes { get; set; } = new List<GeneralIncome>();

    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();
}
