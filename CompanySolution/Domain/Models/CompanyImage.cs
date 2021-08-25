using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanySolution.Domain.Models
{
    public class CompanyImage
    {
        [Key]
        public int ImageID { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string ImageName { get; set; }


       

    }
}
