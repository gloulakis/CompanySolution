using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CompanySolution.Domain.Models
{
    public class Company
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string  CompanyName { get; set; }

        [Required]
        public string Bulstat { get; set; }

        public List<CompanyDetails> details { get; set; }
    }
}
