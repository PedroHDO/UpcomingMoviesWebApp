using System.Threading.Tasks;
using UpcomingMovies.Infra.Data.Entities;

namespace UpcomingMovies.Infra.Data.Api
{
    public interface ITMDbApi
    {
        Task<MovieResponseCollection> GetUpcomingMoviesAsync(ApiQueryStringBuilder queryString = null);

        Task<GenresResponseCollection> GetAllGenresAsync();

        Task<MovieResponse> GetMovieAsync(int id);

        Task<MovieResponseCollection> SearchMoviesAsync(ApiQueryStringBuilder queryStringBuilder = null);
        Task<System.IO.Stream> GetImageByPath(string path);
    }
}