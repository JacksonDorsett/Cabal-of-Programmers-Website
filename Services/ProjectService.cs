
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Cabal_of_Programmers_Website.Data;

namespace Cabal_of_Programmers_Website.Data
{
    public class ProjectService
    {
        protected readonly ApplicationContext _dbContext;
        public ProjectService(ApplicationContext db)
        {
            _dbContext = db;
        }

        public List<ProjectModel> displayProjects(){
            return _dbContext.project.ToList();
        }
    }
}