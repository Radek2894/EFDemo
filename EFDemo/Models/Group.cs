﻿using System.ComponentModel.DataAnnotations;

namespace EFDemo.Models
{
    public class Group
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public ICollection<PersonGroup>? PersonGroups { get; set; }
    }

}
