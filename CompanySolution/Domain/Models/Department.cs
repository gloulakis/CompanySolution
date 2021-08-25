using System;
using System.Collections.Generic;

namespace CompanySolution.Domain.Models
{
    public class Department
    {
        public int id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
