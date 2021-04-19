using Microsoft.EntityFrameworkCore;
using ProjectManagementTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementTool.DAL
{
    public class ProjectManagementDBContext : DbContext
    {
        public ProjectManagementDBContext(DbContextOptions<ProjectManagementDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<Project> Projects { get; set; }

        public virtual DbSet<Registration> Registrations { get; set; }

        public virtual DbSet<Member> TeamMembers { get; set; }

    }
}
