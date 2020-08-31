using bertoni.challenge.api.Models;
using bertoni.challenge.api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace bertoni.challenge.api.Controllers
{
    public class AlbumsController : ApiController
    {
        private AlbumServices _albumServices;

        public AlbumsController()
        {
            _albumServices = new AlbumServices();
        }

        public IHttpActionResult Get()
        {
            var albumns = _albumServices.GetAlbums();
            return Ok(albumns);
        }
    }
}
