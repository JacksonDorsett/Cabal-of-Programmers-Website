using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cabal_of_Programmers_Website.Data
{
    public class ProjectModel
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public DateTime dateposted { get; set; }

        public string repolink { get; set; }

        public string imglink { get; set; }
    }
}
