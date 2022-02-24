using NetFlask.APIRequester.Entities;
using NetFlask.ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetFlask.ASP.Mappers
{
    public static class Mapper
    {
        public static MovieModel ToMovieModel(Movie movie)
        {
            return new MovieModel
            {
                ImdbID = movie.ImdbID,
                Title = movie.Title,
                Poster = movie.Poster,
                Type = movie.Type,
                Year = movie.Year
            };
        }
    }
}