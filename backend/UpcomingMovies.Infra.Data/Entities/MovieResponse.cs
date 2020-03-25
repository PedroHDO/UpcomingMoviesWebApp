using System;

namespace UpcomingMovies.Infra.Data.Entities
{
    public class MovieResponse
    {
        public MovieResponse(int id, string title, DateTime releaseDate, int[] genreIds, string posterPath, string backdropPath, string overview)
        {
            Id = id;
            Title = title;
            Release_Date = releaseDate;
            Genre_Ids = genreIds;
            Poster_Path = posterPath;
            Backdrop_Path = backdropPath;
            Overview = overview;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime? Release_Date { get; set; }

        public int[] Genre_Ids { get; set; }

        public GenreResponse[] Genres { get; set; }

        public string Poster_Path { get; set; }

        public string Backdrop_Path { get; set; }

        public string Overview { get; set; }
    }
}
