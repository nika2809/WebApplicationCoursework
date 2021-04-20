using Microsoft.EntityFrameworkCore;
using ProjectManagementTool.DAL.DBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementTool.DAL.Repositories
{
    public class MemberRepo :BaseRepo, IRepository<Member>
    {
        public MemberRepo(ProjectManagementDBContext context)
        :base(context)
        {
           
        }
        public async Task CreateAsync(Member entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int Id)
        {
            var member = await _context.TeamMembers.FindAsync(Id);
            _context.TeamMembers.Remove(member);
            await _context.SaveChangesAsync(); 
        }

        public async Task<List<Member>> GetAllAsync()
        {
           return await _context.TeamMembers.Include(m => m.Projects).ToListAsync();
        }

        public async Task<Member> GetByIdAsync(int Id)
        {
            return await _context.TeamMembers
                .Include(m => m.Projects)
                .FirstOrDefaultAsync(m => m.MemberID == Id);
        }

        public async Task UpdateAsync(Member entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }

        public bool Exists(int id)
        {
            return _context.TeamMembers.Any(m => m.MemberID == id);
        }
    }
}
