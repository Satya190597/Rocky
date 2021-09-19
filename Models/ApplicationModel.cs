using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
{
    public class ApplicationModel
    {
        [Key]
        public int ApplicationId { get; set; }
        [Required]
        public string Name { get; set; }

    }
}
