using System.Threading.Tasks;
using UpcomingMovies.Infra.Data.Entities;

namespace UpcomingMovies.Infra.Data.Api
{
    public interface ITMDbApi
    {
        Task<MovieResponseCollection> GetUpcomingMoviesAsync(QueryStringBuilder queryString);

        Task<GenresResponseCollection> GetAllGenresAsync();

        Task<MovieResponse> GetMovieAsync(int id);

        Task<MovieResponseCollection> SearchMoviesAsync(QueryStringBuilder queryStringBuilder);
        Task<System.IO.Stream> GetImageByPath(string path);
    }
}