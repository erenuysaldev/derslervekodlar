using System;
using System.Collections.Generic;

namespace Project07_EfCore_DbFirst_Portfolio.Data.Entities;

public partial class HomeBanner
{
    public int? Id { get; set; }

    public string HomeBannerTitle { get; set; } = null!;

    public string HomeBannerSubTitle { get; set; } = null!;

    public string HomeBannerText { get; set; } = null!;

    public string HomeBannerImageUrl { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
