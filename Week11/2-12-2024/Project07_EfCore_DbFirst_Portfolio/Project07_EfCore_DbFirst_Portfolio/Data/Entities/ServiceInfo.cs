using System;
using System.Collections.Generic;

namespace Project07_EfCore_DbFirst_Portfolio.Data.Entities;

public partial class ServiceInfo
{
    public int? Id { get; set; }

    public string Title { get; set; } = null!;

    public string SubTitle { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
