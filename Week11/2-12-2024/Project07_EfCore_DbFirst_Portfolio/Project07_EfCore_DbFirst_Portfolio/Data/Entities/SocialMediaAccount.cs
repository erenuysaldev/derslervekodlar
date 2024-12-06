using System;
using System.Collections.Generic;

namespace Project07_EfCore_DbFirst_Portfolio.Data.Entities;

public partial class SocialMediaAccount
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string AccountUrl { get; set; } = null!;

    public string Icon { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
