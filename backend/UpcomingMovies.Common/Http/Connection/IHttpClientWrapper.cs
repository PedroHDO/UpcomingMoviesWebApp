using System.IO;
using System.Threading.Tasks;

namespace UpcomingMovies.Common.Http.Connection
{
    public interface IHttpClientWrapper
    {
        string ApiToken { get; set; }

        string BaseAddress { get; set; }

        Task<string> GetStringAsync(string path = "", string parameters = "");

        Task<Stream> GetStreamAsync(string path);
    }
}
