using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeudanBeaga.DAL.Model
{
    public class Faq : BaseObject
    {
        [Required]
        [MaxLength(1000)]
        public string Question { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Answer { get; set; }

        public int Order { get; set; }
    }
}
