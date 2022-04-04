﻿using Castle.MicroKernel.SubSystems.Conversion;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFDemo.Models
{
    public class Address
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Street { get; set; }
        [Required]
        [MaxLength(50)]
        public string City { get; set; }
        [Required]
        [MaxLength(6)]
        [Column(TypeName = "varchar(6)")]
        public string ZipCode { get; set; }
        [Required]
        [MaxLength(2)]
        public string Country { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }

    }

}
