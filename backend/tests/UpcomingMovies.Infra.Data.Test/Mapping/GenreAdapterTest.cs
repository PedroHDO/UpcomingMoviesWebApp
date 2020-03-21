using FluentAssertions;
using UpcomingMovies.Infra.Data.Mapping;
using UpcomingMovies.Infra.Data.Test.ObjectMothers;
using Xunit;

namespace UpcomingMovies.Infra.Data.Test.Mapping
{
    public class GenreAdapterTest
    {
        [Fact]
        public void ConvertToGenre_ShouldPresentAGenreWithTheSameId()
        {
            var response = GenreResponseMother.Action;
            var adapter = new GenreAdapter(response);
            var genre = adapter.ConvertToGenre();

            genre.Id.Should().Be(response.Id);
        }

        [Fact]
        public void ConvertToGenre_ShouldPresentAGenreWithTheSameName()
        {
            var response = GenreResponseMother.Action;
            var adapter = new GenreAdapter(response);
            var genre = adapter.ConvertToGenre();

            genre.Name.Should().Be(response.Name);
        }
    }
}
