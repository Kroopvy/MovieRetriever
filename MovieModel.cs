using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetFlask.ASP.Models
{
    public class MovieModel
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Poster { get; set; }
        public string ImdbID { get; set; }
        public string Type { get; set; }
    }
}