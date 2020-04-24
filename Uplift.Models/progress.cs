using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Uplift.Models
{
    public class progress
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        public String UserId { get; set; }
        public DateTime CreateDate { get; set; }

        [ForeignKey("UserId")]
        public IdentityUser IdentityUser { get; set; }

        public int flights { get; set; }
        public int steps { get; set; }
        public double distance { get; set; }
    }
}
