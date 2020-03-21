namespace UpcomingMovies.Infra.Data.Entities
{
    public class GenreResponse
    {
        public GenreResponse(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}
