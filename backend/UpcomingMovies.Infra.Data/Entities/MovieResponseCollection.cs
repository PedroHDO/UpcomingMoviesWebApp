namespace UpcomingMovies.Infra.Data.Entities
{
    public class MovieResponseCollection
    {
        public int Page { get; set; }
        public int Total_Results { get; set; }
        public int Total_Pages { get; set; }
        public MovieResponse[] Results { get; set; }

    }
}
