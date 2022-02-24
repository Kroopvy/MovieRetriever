using MovieRetriever.APIRequester.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
//using System.Threading;
using System.Threading.Tasks;
using ToolBox.Requester;

namespace MovieRetriever.APIRequester.Services
{
    public class IMDBRequester : RequesterBase
    {
        // CancellationToken tok
        //   = default(CancellationToken);
        public IMDBRequester(HttpClient client)
            : base(client)
        {

        }
        public Task<SearchResults> Search(string keyword, int Page)
        {
           // List<Movie> testResults ;
            string uri
                = "http://www.omdbapi.com/?apikey=11ac795b&s="+ keyword+"&Page="+Page;              // ? apikey = f0029eff&s=     (old key)
                                                                                      // + keyword;
       //   testResults = (Get<SearchResults>(uri)).Result.Search;
            return Get<SearchResults>(uri);                     // ,tok
        }
    }
}
