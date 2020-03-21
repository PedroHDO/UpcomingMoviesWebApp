using System.Collections.Generic;
using UpcomingMovies.Domain.Entities;
using UpcomingMovies.Domain.Repositories;

namespace UpcomingMovies.Domain.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository repository;

        public MovieService(IMovieRepository repository)
        {
            this.repository = repository;
        }

        public Movie GetById(int id) 
            => repository.GetById(id);

        public IEnumerable<Movie> GetUpcomingMovies(int page)
            => repository.GetUpcomingMovies(page);

        public IEnumerable<Movie> SearchMoviesByName(string searchTerm, int page)
            => repository.SearchMoviesByName(searchTerm, page);
    }
}
