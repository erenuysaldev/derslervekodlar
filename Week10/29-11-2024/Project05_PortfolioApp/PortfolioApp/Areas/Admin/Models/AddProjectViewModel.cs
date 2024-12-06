﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace PortfolioApp.Areas.Admin.Models
{
    public class AddProjectViewModel
    {
        public string? Title { get; set; }
        public string? SubTitle { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public IFormFile? Image { get; set; }
        public string? Team { get; set; }
        public string? Url { get; set; }
        public string? GithubUrl { get; set; }
        public string? ZipFileUrl { get; set; }
        public IFormFile? ZipFile { get; set; }
        public int CategoryId { get; set; }
        public List<SelectListItem>? CategoryList { get; set; }
    }
}
