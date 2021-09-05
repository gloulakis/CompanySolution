using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanySolution.Domain.Models
{
    public class CompanyDetails
    {
        [Key]
        public int DetailsId { get; set; }

        [Required]
        public string ContractNumber { get; set; }

        public string  Address { get; set; }

        public string  PostCode { get; set; }

        public string City { get; set; }

        [Required]
        public string StartDate { get; set; }

        [Required]
        public string EndDate { get; set; }

        public int CompanyId { get; set; }

        public Company company { get; set; }

    }
}
