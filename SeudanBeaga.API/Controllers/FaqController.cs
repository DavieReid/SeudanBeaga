using SeudanBeaga.DAL;
using SeudanBeaga.DAL.Model;
using SeudanBeaga.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SeudanBeaga.API.Controllers
{
    public class FaqController : ApiController
    {
        FaqService _service;

        private FaqController()
        {
            _service = new FaqService(new SeudanBeagaRepository<Faq>());

        }

        [HttpGet]
        public IEnumerable<Faq> GetAll()
        {
            return _service.GetAll();
        }
    }
}