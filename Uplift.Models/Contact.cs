using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Uplift.Models
{
    public class Contact
    {
        [Key]
        public Guid ID { get; set; }
        public DateTime CreateDate { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }

    }
}
