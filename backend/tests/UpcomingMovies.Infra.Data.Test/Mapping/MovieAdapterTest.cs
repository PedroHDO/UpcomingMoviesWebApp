
using FluentAssertions;
using UpcomingMovies.Infra.Data.Mapping;
using UpcomingMovies.Infra.Data.Test.ObjectMothers;
using Xunit;

namespace UpcomingMovies.Infra.Data.Test.Mapping
{
    public class MovieAdapterTest
    {
        [Fact]
        public void ConvertToMovie_ShouldPresentAMovieWithTheSameId()
        {
            var movieResponse = MovieResponseMother.MerrilyWeRollAlong;
            var movieAdapter = new MovieAdapter(movieResponse);
            var movie = movieAdapter.ConvertToMovie();

            movie.Id.Should().Be(movieResponse.Id);
        }

        [Fact]
        public void ConvertToMovie_ShouldPresentAMovieWithTheSameReleaseDate()
        {
            var movieResponse = MovieResponseMother.MerrilyWeRollAlong;
            var movieAdapter = new MovieAdapter(movieResponse);
            var movie = movieAdapter.ConvertToMovie();

            movie.ReleaseDate.Should().Be(movieResponse.Release_Date);
        }

        [Fact]
        public void ConvertToMovie_ShouldPresentAMovieWithTheSameTitle()
        {
            var movieResponse = MovieResponseMother.MerrilyWeRollAlong;
            var movieAdapter = new MovieAdapter(movieResponse);
            var movie = movieAdapter.ConvertToMovie();

            movie.Title.Should().Be(movieResponse.Title);
        }

        [Fact]
        public void ConvertToMovie_ShouldPresentAMovieWithTheSamePoster()
        {
            var movieResponse = MovieResponseMother.PlotUnknown;
            var movieAdapter = new MovieAdapter(movieResponse);
            var movie = movieAdapter.ConvertToMovie();

            movie.PosterPath.Should().Be(movieResponse.Poster_Path);
        }
        [Fact]
        public void ConvertToMovie_WhenThereIsNoPoster_ShouldPresentABackdropImageInPosterPath()
        {
            var movieResponse = MovieResponseMother.MerrilyWeRollAlong;
            var movieAdapter = new MovieAdapter(movieResponse);
            var movie = movieAdapter.ConvertToMovie();

            movie.PosterPath.Should().Be(movieResponse.Backdrop_Path);
        }

        [Fact]
        public void ConvertToMovie_ShouldPresentAMovieWithTheSameGenre()
        {
            var movieResponse = MovieResponseMother.MerrilyWeRollAlong;
            var movieAdapter = new MovieAdapter(movieResponse);
            var movie = movieAdapter.ConvertToMovie();

            movie.GenreIds.Should().BeEquivalentTo(movieResponse.Genre_Ids);
        }
    }
}
