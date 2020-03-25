using System.Collections.Generic;
using UpcomingMovies.Domain.Entities;

namespace UpcomingMovies.Domain.Services
{
    public interface IMovieService
    {
        IEnumerable<Movie> GetUpcomingMovies(int page);

        IEnumerable<Movie> SearchMoviesByName(string searchTerm, int page);

        Movie GetById(int id);
    }
}
