using FluentAssertions;
using Moq;
using System;
using UpcomingMovies.Infra.Data.Api;
using UpcomingMovies.Infra.Data.Entities;
using UpcomingMovies.Infra.Data.Repositories;
using UpcomingMovies.Infra.Data.Test.ObjectMothers;
using Xunit;

namespace UpcomingMovies.Infra.Data.Test.Repositories
{
    public class MoveRepositoryTest
    {
        [Fact]
        public void GetUpcomingMovies_ShouldReturnUncomingMovies()
        {
            var apiMock = new Mock<ITMDbApi>();
            var response = GetTMDbApiSuccessedResponse();
            apiMock.Setup(mock => mock.GetUpcomingMoviesAsync(It.IsAny<QueryStringBuilder>())).ReturnsAsync(response);

            var repository = new MovieRepository(apiMock.Object);

            var upcomingMovies = repository.GetUpcomingMovies(1);

            upcomingMovies.Should()
                .HaveCount(1)
                .And.StartWith(MovieMother.MerrilyWeRollAlong);
        }

        private MovieResponseCollection GetTMDbApiSuccessedResponse()
        {
            var response = new MovieResponseCollection()
            {
                Page = 1,
                Total_Results = 1,
                Total_Pages = 1,
                Results = new[] { MovieResponseMother.MerrilyWeRollAlong }
            };

            return response;
        }
    }
}
