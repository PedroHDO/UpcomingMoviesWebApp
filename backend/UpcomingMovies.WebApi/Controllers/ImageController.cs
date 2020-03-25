using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UpcomingMovies.Infra.Data.Api;

namespace UpcomingMovies.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ImageController : Controller
    {
        private readonly ITMDbApi api;

        public ImageController(ITMDbApi api)
        {
            this.api = api;
        }

        [HttpGet("{path}")]
        public async Task<ActionResult<Stream>> GetAsync(string path)
        {
            return await api.GetImageByPath(path);
        }
    }
}
