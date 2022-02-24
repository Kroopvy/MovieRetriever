using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRetriever.APIRequester.Entities
{
    public class SearchResults
    {
        public List<Movie> Search { get; set; }
        public string TotalResults { get; set; }
        public int Page { get; set; }
    }
}
