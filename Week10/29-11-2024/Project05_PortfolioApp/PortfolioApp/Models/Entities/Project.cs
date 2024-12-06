using System;

namespace PortfolioApp.Models.Entities;

public class Project : BaseEntity, IDatesEntity, IEntity
{
    public string? Title { get; set; }
    public string? SubTitle { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public string? Team { get; set; }
    public string? Url { get; set; }
    public string? GithubUrl { get; set; }
    public string? ZipFileUrl { get; set; }
    public int CategoryId { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
