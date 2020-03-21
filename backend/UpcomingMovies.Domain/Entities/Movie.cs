using System;

namespace UpcomingMovies.Domain.Entities
{
    public class Movie: Entity
    {
        public Movie(int id, string title, DateTime? releaseDate, int[] genreIds, string posterPath, string overview)
        {
            Id = id;
            Title = title;
            ReleaseDate = releaseDate;
            GenreIds = genreIds;
            PosterPath = posterPath;
            Overview = overview;
        }

        public string Title { get; private set; }

        public DateTime? ReleaseDate { get; private set; }

        public int[] GenreIds { get; private set; }

        public string PosterPath { get; private set; }

        public string Overview { get; private set; }


    }
}
