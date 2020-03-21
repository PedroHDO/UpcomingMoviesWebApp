using System.Collections.Generic;
using UpcomingMovies.Domain.Entities;

namespace UpcomingMovies.Domain.Repositories
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetUpcomingMovies(int page);

        IEnumerable<Movie> SearchMoviesByName(string searchTerm, int page);

        Movie GetById(int id);
    }
}
