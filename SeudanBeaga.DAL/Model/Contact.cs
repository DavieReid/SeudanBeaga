using SeudanBeaga.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeudanBeaga.DAL.Model
{
    public class Contact:BaseObject, IEntity
    {
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Phone { get; set;}
        [MaxLength(255)]
        public string Email { get; set; }
        [MaxLength(10)]
        public string HouseNum { get; set; }
        [MaxLength(255)]
        public string Street { get; set; }
        [MaxLength(255)]
        public string City { get; set; }
        [MaxLength(10)]
        public string PostCode { get; set; }
    }
}
