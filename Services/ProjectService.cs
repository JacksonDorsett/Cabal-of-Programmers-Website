using Cabal_of_programmers.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cabal_of_programmers.services
{
    public class ProjectService
    {
        protected readonly ApplicationContext _context;
        public ProjectService(ApplicationContext _db)
        {
            this._context = _db;
        }

        public List<ProjectModel> GetProjects()
        {
            return _context.project.ToList();
        }
    }

    
}
