using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UpcomingMovies.Domain.Entities;
using UpcomingMovies.Infra.Data.Entities;

namespace UpcomingMovies.Infra.Data.Mapping
{
    public class MovieAdapter
    {
        private readonly MovieResponse movieResponse;

        public MovieAdapter(MovieResponse movieResponse)
        {
            this.movieResponse = movieResponse;
        }
        
        public Movie ConvertToMovie()
        {
            var movie = new Movie(
                    movieResponse.Id,
                    movieResponse.Title,
                    movieResponse.Release_Date,
                    GetGenreIds(),
                    GetPoster(),
                    movieResponse.Overview
                    );

            return movie;
        }

        private string GetPoster()
        {
            return movieResponse.Poster_Path ?? movieResponse.Backdrop_Path;
        }

        private int[] GetGenreIds()
        {
            return movieResponse.Genre_Ids 
                ?? movieResponse.Genres.Select(genre => genre.Id).ToArray();
        }
    }
}
