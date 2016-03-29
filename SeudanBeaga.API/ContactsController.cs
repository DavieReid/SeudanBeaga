using SeudanBeaga.DAL;
using SeudanBeaga.DAL.Interfaces;
using SeudanBeaga.DAL.Model;
using SeudanBeaga.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SeudanBeaga.API
{
    public class ContactsController:ApiController
    {
        ContactsService _service;

        private ContactsController()
        {
            _service = new ContactsService(new SeudanBeagaRepository<Contact>());

        }

        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            return _service.GetAllContacts();
        }
    }
}