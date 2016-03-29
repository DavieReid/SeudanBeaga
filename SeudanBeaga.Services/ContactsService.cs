using SeudanBeaga.DAL.Interfaces;
using SeudanBeaga.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeudanBeaga.Services
{
    public class ContactsService
    {

        private IRepository<Contact> _repo;

        public ContactsService(IRepository<Contact> repo)
        {
            _repo = repo;
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            return _repo.GetAll();
        }
    }
}
