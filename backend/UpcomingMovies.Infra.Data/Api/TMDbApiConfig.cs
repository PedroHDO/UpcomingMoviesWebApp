namespace UpcomingMovies.Infra.Data.Api
{
    public static class TMDbApiConfig
    {
        public static string ApiKey = "1f54bd990f1cdfb230adb312546d765d";

        public static string BaseUri = "https://api.themoviedb.org/";

        public static string BaseImageUri = "https://image.tmdb.org/t/p/w500/";

        public static string UpcomingMoviesEndpoint = "3/movie/upcoming";

        public static string MovieEndpoint = "3/movie";

        public static string GenreEndpoint = "3/genre/movie/list";

        public static string SearchMoviesEndpoint = "3/search/movie";
    }
}
