using System;
using System.Collections.Generic;
using System.Linq;
using UpcomingMovies.Domain.Entities;
using UpcomingMovies.Domain.Repositories;
using UpcomingMovies.Infra.Data.Api;
using UpcomingMovies.Infra.Data.Entities;
using UpcomingMovies.Infra.Data.Enum;
using UpcomingMovies.Infra.Data.Mapping;

namespace UpcomingMovies.Infra.Data.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ITMDbApi api;

        public MovieRepository(ITMDbApi api)
        {
            this.api = api;
        }

        public Movie GetById(int id)
        {
            var movieResponse = api.GetMovieAsync(id).Result;
            return new MovieAdapter(movieResponse).ConvertToMovie();
        }

        public IEnumerable<Movie> GetUpcomingMovies(int page)
        {
            var filter = GetParameter(page);
            var moviesResponse = api.GetUpcomingMoviesAsync(filter).Result;

            var movies = moviesResponse.Results.Select(movieResponse =>
                              new MovieAdapter(movieResponse).ConvertToMovie()
                          );

            return movies;
        }
        private ApiQueryStringBuilder GetParameter(int page)
        {
            var filter = new ApiQueryStringBuilder();
            filter.Equal(QueryStringField.page, page);

            return filter;
        }

        public IEnumerable<Movie> SearchMoviesByName(string searchTerm, int page)
        {
            var filter = GetParameter(page);
            filter.Equal(QueryStringField.query, searchTerm);
            var moviesResponse = api.SearchMoviesAsync(filter).Result;

            var movies = moviesResponse.Results.Select(movieResponse =>
                              new MovieAdapter(movieResponse).ConvertToMovie()
                          );

            return movies;
        }


        
    }
}
