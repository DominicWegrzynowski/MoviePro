using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Models.Database
{
    public class MovieCast
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int CastId { get; set; }
        public string Department { get; set; }
        public string Name { get; set; }
        public string Character { get; set; }
        public string ImageUrl { get; set; }

        //Navigational Property
        public Movie Movie { get; set; }
    }
}
