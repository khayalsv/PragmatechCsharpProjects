﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relation.Models
{
    public class Company
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
