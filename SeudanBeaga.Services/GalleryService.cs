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
        string apiKey = "d66627f08ee8361457195d0e9225b8a0";
        string photoAlbumId = "72157668776452865";
        string userId = "143444427@N06";
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
