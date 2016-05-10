using SeudanBeaga.DAL.Interfaces;
using SeudanBeaga.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeudanBeaga.Services
{
    public class HolidaysService
    {
        private DAL.SeudanBeagaRepository<Holiday> seudanBeagaRepository;
        private IRepository<Holiday> _repo;

        
        public HolidaysService(IRepository<Holiday> repo)
        {
            _repo = repo;
        }

        public IEnumerable<Holiday> GetActiveHolidays()
        {
            return _repo.FindBy(x => x.IsActive);
        }
    }
}
