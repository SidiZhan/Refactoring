using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Refactoring.Libs
{
    #region Http client library version 0.0.0.1

    class HttpCli
    {
        protected readonly HttpClient _client;

        public HttpCli()
        {
            _client = new HttpClient();
        }

        public Task<HttpResponseMessage> SendAsync(string method, Uri uri)
        {
            return _client.SendAsync(new HttpRequestMessage(new HttpMethod(method), uri));
        }
    }

    #endregion
}