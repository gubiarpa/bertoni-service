using bertoni.challenge.api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bertoni.challenge.api.Services
{
    public class AlbumServices
    {
        public List<Album> GetAlbums()
        {
            var albumns = new List<Album>()
            {
                new Album() { Id = Guid.Parse("21ce955b-1c22-4104-87e4-42802d2a1766"), Nombre = "Familiar" },
                new Album() { Id = Guid.Parse("237c392d-09b2-4d17-9cc5-1bae59cf8c04"), Nombre = "Paseo" },
                new Album() { Id = Guid.Parse("5e4f767a-cbd0-4996-b7b9-c8554e51b8ae"), Nombre = "Laboral" },
                new Album() { Id = Guid.Parse("7923d01d-8086-4b13-aba0-5eb5634a9b6b"), Nombre = "Others" }
            };

            return albumns;
        }
    }
}