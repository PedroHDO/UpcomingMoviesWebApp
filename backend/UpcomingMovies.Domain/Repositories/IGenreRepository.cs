using System.Collections.Generic;
using UpcomingMovies.Domain.Entities;

namespace UpcomingMovies.Domain.Repositories
{
    public interface IGenreRepository
    {
        IEnumerable<Genre> GetAll();
    }
}
