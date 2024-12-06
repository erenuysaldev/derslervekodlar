using Microsoft.EntityFrameworkCore;
using PortfolioApp.Areas.Admin.Models;
using PortfolioApp.Models.Entities;

namespace PortfolioApp.Models.Repositories
{
    public class ProjectRepository
    {
        private readonly AppDbContext _context;

        public ProjectRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Project>> GetAllAsync()
        {
            List<Project> projects = await _context.Projects.ToListAsync();
            return projects;
        }

        public async Task<List<Project>> GetAllAsync(bool isDeleted)
        {
            List<Project> projects = await _context
                .Projects
                .Where(p=>p.IsDeleted==isDeleted)
                .ToListAsync();
            return projects;
        }
 
        public async Task<Project?> GetByIdAsync(int id)
        {
            Project? project = await _context
                .Projects
                .Where(p=>p.Id==id)
                .FirstOrDefaultAsync();
            return project;
        }

        public async Task<Project?> GetByIdAsync(int id, bool isDeleted)
        {
            Project? project = await _context
                .Projects
                .Where(p =>p.IsDeleted==isDeleted && p.Id == id)
                .FirstOrDefaultAsync();
            return project;
        }

        public async Task CreateAsync(AddProjectViewModel addProjectViewModel)
        {
            Project project = new()
            {
                CategoryId = addProjectViewModel.CategoryId,
                Description = addProjectViewModel.Description,
                GithubUrl = addProjectViewModel.GithubUrl,
                ImageUrl = addProjectViewModel.ImageUrl,
                SubTitle = addProjectViewModel.SubTitle,
                Team = addProjectViewModel.Team,
                Title = addProjectViewModel.Title,
                Url = addProjectViewModel.Url,
                ZipFileUrl = addProjectViewModel.ZipFileUrl
            };
            await _context.Projects.AddAsync(project);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(UpdateProjectViewModel updateProjectViewModel)
        {
            Project? project = await GetByIdAsync(updateProjectViewModel.Id);
            project.CategoryId= updateProjectViewModel.CategoryId;
            project.Description= updateProjectViewModel.Description;
            project.GithubUrl= updateProjectViewModel.GithubUrl;
            project.ImageUrl= updateProjectViewModel.ImageUrl;
            project.SubTitle= updateProjectViewModel.SubTitle;
            project.Team= updateProjectViewModel.Team;
            project.Title= updateProjectViewModel.Title;    
            project.Url= updateProjectViewModel.Url;
            project.ZipFileUrl= updateProjectViewModel.ZipFileUrl;
            _context.Projects.Update(project);
            await _context.SaveChangesAsync();
        }
    }
}
