using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bertoni.challenge.api.Models
{
    public class Photo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}