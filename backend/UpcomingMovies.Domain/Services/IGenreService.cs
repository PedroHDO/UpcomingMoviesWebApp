using System.Collections.Generic;
using UpcomingMovies.Domain.Entities;

namespace UpcomingMovies.Domain.Services
{
    public interface IGenreService
    {
        IEnumerable<Genre> GetAll();
    }
}
