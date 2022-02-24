﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRetriever.APIRequester.Entities
{
    public class Movie
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Poster { get; set; }
        public string ImdbID { get; set; }
        public string Type { get; set; }
    }
}
