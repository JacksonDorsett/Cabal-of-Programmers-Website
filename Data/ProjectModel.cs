﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cabal_of_programmers.Data
{
    public class ProjectModel
    {
        [Key]
        public string name { get; set; }

        public string description { get; set; }

        public DateTime dateposted { get; set; }

        public string gitlink { get; set; }

        public string imageurl { get; set; }
    }
}
