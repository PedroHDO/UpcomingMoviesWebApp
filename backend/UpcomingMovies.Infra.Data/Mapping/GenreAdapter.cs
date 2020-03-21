using UpcomingMovies.Domain.Entities;
using UpcomingMovies.Infra.Data.Entities;

namespace UpcomingMovies.Infra.Data.Mapping
{
    public class GenreAdapter
    {
        private readonly GenreResponse GenreResponse;

        public GenreAdapter(GenreResponse GenreResponse)
        {
            this.GenreResponse = GenreResponse;
        }

        public Genre ConvertToGenre()
        {
            var Genre = new Genre(
                    GenreResponse.Id,
                    GenreResponse.Name
                    );

            return Genre;
        }

    }
}
