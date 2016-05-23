using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FlickrNet;
using SeudanBeaga.Services;
using System.Web.Http;
using SeudanBeaga.DAL.Model;
using System.Threading.Tasks;

namespace SeudanBeaga.API.Controllers
{
    public class GalleryController : ApiController
    {
        GalleryService _service;

        public GalleryController()
        {
            _service = new GalleryService();
        }

        [HttpGet]
        [ActionName("Get")]
        public PhotosetPhotoCollection Get()
        {
            return _service.GetPhotoSet();
        }
    }
}