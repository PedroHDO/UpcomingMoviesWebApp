using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using UpcomingMovies.Domain.Entities;
using UpcomingMovies.Domain.Services;

namespace UpcomingMovies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreService service;

        public GenreController(IGenreService service)
        {
            this.service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Genre>> Get()
        {
            return service.GetAll().ToArray();
        }
    }
}