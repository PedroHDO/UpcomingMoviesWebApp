using System.Threading.Tasks;
using UpcomingMovies.Common.Converters;
using UpcomingMovies.Common.Http.Connection;
using UpcomingMovies.Infra.Data.Entities;

namespace UpcomingMovies.Infra.Data.Api
{
    public class TMDbApi : ITMDbApi
    {
        private readonly IHttpClientWrapper client;

        public TMDbApi(IHttpClientWrapper client)
        {
            this.client = client;
        }

        private IHttpClientWrapper GetDataClient()
        {
            client.ApiToken = TMDbApiConfig.ApiKey;
            client.BaseAddress = TMDbApiConfig.BaseUri;
            return client;
        }

        private IHttpClientWrapper GetImageClient()
        {
            client.BaseAddress = TMDbApiConfig.BaseImageUri;
            return client;
        }

        public async Task<MovieResponseCollection> GetUpcomingMoviesAsync(ApiQueryStringBuilder queryString = null)
        {
            var response = await GetDataClient().GetStringAsync(TMDbApiConfig.UpcomingMoviesEndpoint, queryString?.ToString());

            var movieResponseCollection = JsonConverter.Deserialize<MovieResponseCollection>(response);

            return movieResponseCollection;
        }

        public async Task<MovieResponse> GetMovieAsync(int id)
        {
            var response = await GetDataClient().GetStringAsync($"{TMDbApiConfig.MovieEndpoint}/{id}");

            var movieResponse = JsonConverter.Deserialize<MovieResponse>(response);

            return movieResponse;
        }

        public async Task<GenresResponseCollection> GetAllGenresAsync()
        {
            var response = await GetDataClient().GetStringAsync(TMDbApiConfig.GenreEndpoint);

            var genreResponse = JsonConverter.Deserialize<GenresResponseCollection>(response);

            return genreResponse;
        }

        public async Task<MovieResponseCollection> SearchMoviesAsync(ApiQueryStringBuilder queryString = null)
        {
            var response = await GetDataClient().GetStringAsync(TMDbApiConfig.SearchMoviesEndpoint, queryString?.ToString());

            var movieResponseCollection = JsonConverter.Deserialize<MovieResponseCollection>(response);

            return movieResponseCollection;
            
        }
        public async Task<System.IO.Stream> GetImageByPath(string path)
        {
            var response = await GetImageClient().GetStreamAsync(path);
            return response;
        }
    }
}
