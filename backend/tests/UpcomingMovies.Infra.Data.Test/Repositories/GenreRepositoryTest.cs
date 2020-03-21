using System;
using FluentAssertions;
using Moq;
using UpcomingMovies.Domain.Entities;
using UpcomingMovies.Infra.Data.Api;
using UpcomingMovies.Infra.Data.Entities;
using UpcomingMovies.Infra.Data.Repositories;
using UpcomingMovies.Infra.Data.Test.ObjectMothers;
using Xunit;

namespace UpcomingMovies.Infra.Data.Test.Repositories
{
    public class GenreRepositoryTest
    {
        [Fact]
        public void GetAll_WhenApiWasSeccessed_ShouldMapAllGenre()
        {
            var apiMock = new Mock<ITMDbApi>();
            var response = GetTMDbApiSuccessedResponse();
            apiMock.Setup(mock => mock.GetAllGenresAsync()).ReturnsAsync(response);

            var repository = new GenreRepository(apiMock.Object);

            var genres = repository.GetAll();

            genres.Should().BeEquivalentTo(GetAllGenresExpected());
        }

        private Genre[] GetAllGenresExpected()
        {
            return new[] {
                    GenreMother.Action,
                    GenreMother.Adventure,
                    GenreMother.Animation
                };
        }

        private GenresResponseCollection GetTMDbApiSuccessedResponse()
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
