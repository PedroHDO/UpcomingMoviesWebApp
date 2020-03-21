using System;
using UpcomingMovies.Domain.Entities;
using UpcomingMovies.Infra.Data.Entities;

namespace UpcomingMovies.Infra.Data.Test.ObjectMothers
{
    public static class MovieResponseMother
    {
        public static MovieResponse MerrilyWeRollAlong
            = new MovieResponse(id: 627012, title: "Merrily We Roll Along", releaseDate: new DateTime(2040, 01, 01), new[] { 10402 }, null, "aaa.png", "...");

        public static MovieResponse PlotUnknown
            = new MovieResponse(id: 393209, title: "Plot unknown", releaseDate: new DateTime(2027, 12, 15), new[] { 28, 12, 14, 878 }, "/krOMOEjDpw3Mf2EuJb9OgmqD6ft.jpg", null, "...");

        public static MovieResponse BlackBlood
            = new MovieResponse(id: 519258, title: "Black Blood", releaseDate: new DateTime(2026, 08, 31), new[] { 18, 53 }, "/adFRjMiYYXrekiLe0XAoZKmhD9d.jpg", null, "...");
    }

    public static class MovieMother
    {
        public static Movie MerrilyWeRollAlong
            = new Movie(id: 627012, title: "Merrily We Roll Along", releaseDate: new DateTime(2040, 01, 01), new[] { 10402 }, null, "...");

        public static Movie PlotUnknown
            = new Movie(id: 393209, title: "Plot unknown", releaseDate: new DateTime(2027, 12, 15), new[] { 28, 12, 14, 878 }, "/krOMOEjDpw3Mf2EuJb9OgmqD6ft.jpg", "...");

        public static Movie BlackBlood
            = new Movie(id: 519258, title: "Black Blood", releaseDate: new DateTime(2026, 08, 31), new[] { 18, 53 }, "/adFRjMiYYXrekiLe0XAoZKmhD9d.jpg", "...");
    }

    public static class GenreMother
    {
        public static Genre Action = new Genre(28, "Action");
        public static Genre Adventure = new Genre(12, "Adventure");
        public static Genre Animation = new Genre(16, "Animation");
    }

    public static class GenreResponseMother
    {
        public static GenreResponse Action = new GenreResponse(28, "Action");
        public static GenreResponse Adventure = new GenreResponse(12, "Adventure");
        public static GenreResponse Animation = new GenreResponse(16, "Animation");
    }

    public static class ApiResponsesMother
    {
        public static string GenreSuccessedResponse
            => "{\"genres\": [{\"id\": 28, \"name\": \"Action\"}, {\"id\": 12,\"name\": \"Adventure\"}, {\"id\": 16,\"name\": \"Animation\"}]}";

        public static string DiscoverMovieSuccessedResponse
            => "{\"page\":1,\"total_results\":1,\"total_pages\":1," +
               "\"results\":[{\"popularity\":1.437,\"vote_count\":0," +
               "\"video\":false,\"poster_path\":null,\"id\":627012," +
               "\"adult\":false,\"backdrop_path\":\"aaa.png\",\"original_language\":\"en\"," +
               "\"original_title\":\"Merrily We Roll Along\",\"genre_ids\":[10402]," +
               "\"title\":\"Merrily We Roll Along\",\"vote_average\":0," +
               "\"overview\":\"...\"" +
               ",\"release_date\":\"2040-01-01\"}]}";
    }

}
