namespace UpcomingMovies.Domain.Entities
{
    public class Genre : Entity
    {
        public Genre(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Name { get; private set; }
    }
}
