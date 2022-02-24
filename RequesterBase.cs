using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ToolBox.Requester
{
    public abstract class RequesterBase 
        : IDisposable
    {
        protected readonly HttpClient _Client;

        public RequesterBase(HttpClient client)
        {
            _Client = client;
        }

        public async Task<TResult> Get<TResult>
            (string url, CancellationToken token 
            = default(CancellationToken))
        {
            HttpResponseMessage resp
                = await _Client.GetAsync(url, token);
            if (!resp.IsSuccessStatusCode)
            {
                throw new HttpRequestException("Invalid Request");
            }
            string json = await resp.Content.ReadAsStringAsync();

            // convertir le json en l'objet souhaité (TResult)
            return JsonConvert.DeserializeObject<TResult>(json);
            //f0029eff
        }

        public void Dispose()
        {
            _Client.Dispose();
        }
    }
}
