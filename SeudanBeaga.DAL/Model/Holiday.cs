using SeudanBeaga.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeudanBeaga.DAL.Model
{
    public class Holiday:BaseObject, IEntity
    {
        public DateTime Date { get; set; }

        public bool IsActive { get; set; }
    }
}
