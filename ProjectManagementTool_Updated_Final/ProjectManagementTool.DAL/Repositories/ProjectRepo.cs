using ProjectManagementTool.DAL.DBO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace ProjectManagementTool.DAL.Repositories
{
    public class ProjectRepo : BaseRepo, IRepository<Project>
    {
          public ProjectRepo(ProjectManagementDBContext context)
            : base(context)
        {
        }

        public async Task CreateAsync(Project entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
            
        }

        public async Task DeleteAsync(int Id)
        {
            var project = await _context.Projects.FindAsync(Id);
            _context.Projects.Remove(project);
            await _context.SaveChangesAsync(); 

        }

        public Task<Project> GetAllAsync()
        {
           return await _context.Projects.Include(p => p.TeamMembers).ToListAsync();
        }

        public async Task<Project> GetByIdAsync(int Id)
        {
           return await _context.Projects
                .Include(p => p.TeamMembers)
                .FirstOrDefaultAsync(m => m.ProjectID == Id);
            
        }

        public async Task UpdateAsync(Project entity)
        {
            _context.Update(entity);
             await _context.SaveChangesAsync();
        }

        public bool Exists(int id)
        {
             return _context.Projects.Any(e => e.ProjectID == id);
        }

        public Task<List<Project>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}