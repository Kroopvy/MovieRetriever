using MovieRetriever.APIRequester.Entities;
using MovieRetriever.APIRequester.Services;
using MovieRetriever.ASP.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MovieRetriever.ASP.Helpers;


namespace MovieRetriever.ASP.Controllers
{
    public class MovieController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        //public async Task<ActionResult> Search(SearchForm form)
        public async Task<ActionResult> Search(SearchForm form1)
        {
            if (ModelState.IsValid)
            {
                using (IMDBRequester req
                    = new IMDBRequester(new HttpClient()))
                {

                    SearchResults searchResults
                        = await req.Search(form1.KeyWord, form1.Page);
                    List<Movie> movies = searchResults.Search;//Result;
                    searchResults.Page = form1.Page;
                    //ViewBag.KeyWord = form1.KeyWord;
                    //ViewBag.Page = form1.Page;
                    Session["KeyWord"] = form1.KeyWord;
                    Session["Page"] = form1.Page;
                    //foreach (SearchResult searchResult in movies)
                    //    {
                    //    string Title = movie.Title;
                    //    string Year = movie.Year;
                    //    string Type = movie.Type;
                    //    string ImdbID = movie.ImdbID;
                    //    string Poster = movie.Poster;
                    //}
                    //ViewBag.KeyWord = (string)Session["KeyWord"];
                    //ViewBag.Page = (int)Session["Page"];
                    return View(searchResults);
                }
            }
            return View();            //View(form.KeyWord);

        }
    }
}

//        [HttpPost]
//        public async Task<ActionResult> SearchPrev()  //string keyWord, int page
//        {
//            if (ModelState.IsValid)
//            {
//                using (IMDBRequester req
//                    = new IMDBRequester(new HttpClient()))
//                {

//                    SearchResults searchResults
//                        = await req.Search((string)Session["KeyWord"],(int)Session["Page"] - 1);
//                    List<Movie> movies = searchResults.Search;//Result;



//                    return View(searchResults);
//                }
//            }
//            return View();
//        }

//    }
//}
