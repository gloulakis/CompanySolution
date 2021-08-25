using System;
using System.ComponentModel.DataAnnotations;

namespace CompanySolution.Domain.Models
{
    public class CompanieDetails
    {
        [Key]
        public int DetailsId { get; set; }

        [Required]
        public string ContractNumber { get; set; }

        [Required]
        public string StartDate { get; set; }

        [Required]
        public string EndDate { get; set; }

       

    }
}
