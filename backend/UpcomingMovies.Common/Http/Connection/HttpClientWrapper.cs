using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace UpcomingMovies.Common.Http.Connection
{
    public class HttpClientWrapper : IHttpClientWrapper
    {
        private readonly HttpClient httpClient;

        public HttpClientWrapper(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public string ApiToken { get; set; }

        public string BaseAddress
        {
            get => httpClient.BaseAddress.ToString();
            set => httpClient.BaseAddress = new Uri(value);
        }
        private string GetApiTokenParameter => $"api_key={ApiToken}";

        public async Task<Stream> GetStreamAsync(string path)
        {
            return await httpClient.GetStreamAsync(path);
        }

        public async Task<string> GetStringAsync(string endpoint = "", string parameters = "")
        {
            var requestUri = $"{endpoint}?{GetApiTokenParameter}";

            if (!string.IsNullOrEmpty(parameters))
                requestUri += $"&{parameters}";

            return await httpClient.GetStringAsync(requestUri);
        }
    }
}
