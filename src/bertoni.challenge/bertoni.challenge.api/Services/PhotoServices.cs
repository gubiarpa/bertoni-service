using bertoni.challenge.api.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bertoni.challenge.api.Services
{
    public class PhotoServices
    {
        public List<Photo> GetPhotos(Guid idAlbum)
        {
            var photos = new List<Photo>();

            if (idAlbum.Equals(Guid.Parse("21ce955b-1c22-4104-87e4-42802d2a1766")))
            {
                photos.Add(new Photo() { Id = Guid.Parse("e02fa57f-9c27-4c19-97df-8f10ff4789a9"), Name = "Phoebe Patrick", Url = "" });
                photos.Add(new Photo() { Id = Guid.Parse("d1a281a1-fb3a-4e3a-884e-e94f6824e444"), Name = "Nick Patrick", Url = "" });
                photos.Add(new Photo() { Id = Guid.Parse("9a5554f5-4c4f-48f1-9b78-4b64c30587fb"), Name = "Anand Duran", Url = "" });
                photos.Add(new Photo() { Id = Guid.Parse("8659ff65-b697-44ff-8d44-8da812432b62"), Name = "Bruce Bowden", Url = "" });
            }
            else if (idAlbum.Equals(Guid.Parse("237c392d-09b2-4d17-9cc5-1bae59cf8c04")))
            {
                photos.Add(new Photo() { Id = Guid.Parse("90e1cad9-dd80-42b9-a5fa-bc9c68fecfc9"), Name = "Mischa Corbett", Url = "" });
                photos.Add(new Photo() { Id = Guid.Parse("775281e9-693e-4175-b75a-ea8c2368e616"), Name = "Humzah Joyner", Url = "" });
                photos.Add(new Photo() { Id = Guid.Parse("84d31ebd-fd43-4cd7-b7cc-115ae28a0dbf"), Name = "Sami Vaughn", Url = "" });
            }
            else if (idAlbum.Equals(Guid.Parse("5e4f767a-cbd0-4996-b7b9-c8554e51b8ae")))
            {
                photos.Add(new Photo() { Id = Guid.Parse("d1a281a1-fb3a-4e3a-884e-e94f6824e444"), Name = "Nick Patrick", Url = "" });
            }
            else if (idAlbum.Equals(Guid.Parse("7923d01d-8086-4b13-aba0-5eb5634a9b6b")))
            {
                photos.Add(new Photo() { Id = Guid.Parse("5112d869-de8a-4dc1-b15d-91895c7e7d84"), Name = "Asa Dennis", Url = "" });
                photos.Add(new Photo() { Id = Guid.Parse("101de0f7-578f-4f7a-b87d-488b23a07cf1"), Name = "Zahrah Sheldon", Url = "" });
                photos.Add(new Photo() { Id = Guid.Parse("742d1f0e-77f8-4f5a-8366-d3ddc3af71f8"), Name = "Olive Barnes", Url = "" });
                photos.Add(new Photo() { Id = Guid.Parse("970bb31f-0ca6-4dd0-a97f-846d61147b90"), Name = "Jeevan Dixon", Url = "" });
            }

            return photos;
        }
    }
}