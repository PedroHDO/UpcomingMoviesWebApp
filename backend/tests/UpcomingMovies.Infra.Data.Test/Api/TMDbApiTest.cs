using FluentAssertions;
using Moq;
using UpcomingMovies.Common.Http.Connection;
using UpcomingMovies.Infra.Data.Api;
using UpcomingMovies.Infra.Data.Entities;
using UpcomingMovies.Infra.Data.Test.ObjectMothers;
using Xunit;

namespace UpcomingMovies.Infra.Data.Test.Api
{
    public class TMDbApiTest
    {
        [Fact]
        public void GetUpcomingMovies_WhenSuccessed_ShouldReturnTheDiscoverMovieResponse()
        {
            var clientMock = new Mock<IHttpClientWrapper>();
            clientMock.Setup(mock =>
                             mock.GetStringAsync(TMDbApiConfig.UpcomingMoviesEndpoint, It.IsAny<string>())
                       )
                      .ReturnsAsync(ApiResponsesMother.DiscoverMovieSuccessedResponse);

            var api = new TMDbApi(clientMock.Object);

            var apiResponse = api.GetUpcomingMoviesAsync().Result;

            apiResponse.Should().BeEquivalentTo(GetDiscoverMovieExpectedSuccessedResponse());
        }

        private MovieResponseCollection GetDiscoverMovieExpectedSuccessedResponse()
        {
            var response = new MovieResponseCollection()
            {
                Page = 1,
                Total_Results = 1,
                Total_Pages = 1,
                Results = new [] { MovieResponseMother.MerrilyWeRollAlong }
            };

            return response;
        }

        [Fact]
        public void GetAllGenres_WhenSuccessed_ShouldReturnAGenreCollectionResponse()
        {
            var clientMock = new Mock<IHttpClientWrapper>();
            clientMock.Setup(mock => 
                             mock.GetStringAsync(TMDbApiConfig.GenreEndpoint, It.IsAny<string>())
                       )
                      .ReturnsAsync(ApiResponsesMother.GenreSuccessedResponse);

            var api = new TMDbApi(clientMock.Object);

            var apiResponse = api.GetAllGenresAsync().Result;

            apiResponse.Should().BeEquivalentTo(GetGenreCollectionExpectedSuccessedResponse());
        }

        private GenresResponseCollection GetGenreCollectionExpectedSuccessedResponse()
        {
            return new GenresResponseCollection()
            {
                Genres = new[] {
                    GenreResponseMother.Action,
                    GenreResponseMother.Adventure,
                    GenreResponseMother.Animation
                }
            };
        }

    }
}
