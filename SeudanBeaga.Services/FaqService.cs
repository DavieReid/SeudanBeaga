using SeudanBeaga.DAL.Interfaces;
using SeudanBeaga.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeudanBeaga.Services
{
   public class FaqService
    {
        private IRepository<Faq> _repo;

        public FaqService(IRepository<Faq> repo)
        {
            _repo = repo;
        }

        public IEnumerable<Faq> GetAll()
        {
            return _repo.GetAll();
        }
    }
}
