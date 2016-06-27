using Newtonsoft.Json;
using SeudanBeaga.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FlickrNet;

namespace SeudanBeaga.Services
{
    public class GalleryService
    {
        const string apiKey = "0c3b0b4e72b30fc8c7230afbc553d3c2";
        const string photoAlbumId = "72157670213759936";
        const string userId = "144509354@N02";
        Flickr _flickr;

        public GalleryService()
        {
            _flickr = new Flickr(apiKey);
        }


        public PhotosetPhotoCollection GetPhotoSet()
        {
            return _flickr.PhotosetsGetPhotos(photoAlbumId,
                PhotoSearchExtras.All,
                PrivacyFilter.PublicPhotos);
        }
    }
}
