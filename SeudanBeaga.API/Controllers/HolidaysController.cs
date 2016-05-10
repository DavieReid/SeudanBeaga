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
    public class HolidaysController
    {

        HolidaysService _service;

        private HolidaysController()
        {
            _service = new HolidaysService(new SeudanBeagaRepository<Holiday>());
        }

        [HttpGet]
        public IEnumerable<Holiday> Get()
        {
            return _service.GetActiveHolidays();
        }
    }
}