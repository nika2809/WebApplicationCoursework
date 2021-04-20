using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectManagementTool.DAL.Repositories
{
    public abstract class BaseRepo
    {
        protected readonly ProjectManagementDBContext _context;

        protected BaseRepo (ProjectManagementDBContext context)
        {
            _context = context;
        }

    }
}
