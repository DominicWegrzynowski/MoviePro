using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Models.Database
{
    public class MovieCollection
    {
        public int Id { get; set; }
        public int CollectionId { get; set; }
        public int MovieId { get; set; }

        public int Order { get; set; }

        //Navigational Properties
        public Collection Collection { get; set; }
        public Movie Movie { get; set; }
    }
}
