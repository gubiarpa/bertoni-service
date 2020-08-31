using bertoni.challenge.api.Models;
using bertoni.challenge.api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace bertoni.challenge.api.Controllers
{
    public class PhotosController : ApiController
    {
        private PhotoServices _photoServices;

        public PhotosController()
        {
            _photoServices = new PhotoServices();
        }

        public IHttpActionResult Get([FromUri]Guid idAlbum)
        {
            var albumns = _photoServices.GetPhotos(idAlbum);
            return Ok(albumns);
        }
    }
}
