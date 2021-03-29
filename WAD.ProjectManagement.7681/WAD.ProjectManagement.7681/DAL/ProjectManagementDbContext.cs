using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAD.ProjectManagement._7681.Models;

namespace WAD.ProjectManagement._7681.DAL
{
    public class ProjectManagementDbContext : DbContext
    {

        public ProjectManagementDbContext(DbContextOptions<ProjectManagementDbContext> options) : base(options)
        {


        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<TeamMember> TeamMembers { get; set; }
        public virtual DbSet<Project> Projects { get; set; }



    }
}
