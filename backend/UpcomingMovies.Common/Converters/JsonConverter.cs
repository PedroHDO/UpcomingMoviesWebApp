namespace UpcomingMovies.Common.Converters
{
    public class JsonConverter
    {
        public static T Deserialize<T>(string json)
            => Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
    }
}
