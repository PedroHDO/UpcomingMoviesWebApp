using System.Collections.Generic;
using System.Linq;
using UpcomingMovies.Domain.Entities;
using UpcomingMovies.Domain.Repositories;
using UpcomingMovies.Infra.Data.Api;
using UpcomingMovies.Infra.Data.Mapping;

namespace UpcomingMovies.Infra.Data.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private readonly ITMDbApi api;

        public GenreRepository(ITMDbApi api)
        {
            this.api = api;
        }

        public IEnumerable<Genre> GetAll()
        {
            var response = api.GetAllGenresAsync().Result;

            var genres = response.Genres.Select(genre => new GenreAdapter(genre).ConvertToGenre());

            return genres;
        }
    }
}
