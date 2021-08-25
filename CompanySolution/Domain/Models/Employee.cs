using System;
namespace CompanySolution.Domain.Models
{
    public class Employee
    {
        public int id { get; set; }

        public string Name { get; set; }

        public String Address { get; set; }

        public string HiredDate { get; set; }

        public string Active { get; set; }

        public virtual Department Department { get; set; }
    }
}
