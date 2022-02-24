using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NetFlask.ASP.Models
{
    public class SearchFormModel
    {
        [Required]
        [MinLength(3)]
        public string Keyword { get; set; }

        public int TotalResults { get; set; }

        public List<MovieModel> Results { get; set; }

        public int Page { get; set; } = 1;
    }
}