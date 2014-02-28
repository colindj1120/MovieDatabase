using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase.Objects
{
    public class Movies
    {
        public string MoveName { get; set; }
        public List<string> Genres = new List<string>();
        public string TimeLength { get; set; }
        public string Gross { get; set; }
        public string ReleaseDate { get; set; }
    }
}
