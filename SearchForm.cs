using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRetriever.ASP.Models
{
    public class SearchForm
    {
        public SearchForm()
        {

        }

        public SearchForm(string keyWord, int p)
        {
            this.KeyWord = keyWord;
            this.Page = p;
        }

        [Required]
        [MinLength(3)]
        public string KeyWord { get; set; }
        public int Page { get; set; }
    }
}