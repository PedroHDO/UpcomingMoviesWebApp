using System;
using System.Collections.Generic;
using System.Text;
using UpcomingMovies.Domain.Entities;
using UpcomingMovies.Domain.Repositories;

namespace UpcomingMovies.Domain.Services
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository repository;

        public GenreService(IGenreRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Genre> GetAll()
            => repository.GetAll();
    }
}
