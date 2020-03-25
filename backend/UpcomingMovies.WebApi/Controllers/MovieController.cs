using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using UpcomingMovies.Domain.Entities;
using UpcomingMovies.Domain.Services;

namespace UpcomingMovies.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService service;

        public MovieController(IMovieService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("upcoming")]
        public ActionResult<IEnumerable<Movie>> GetUpcoming(int page = 1)
        {
            return service.GetUpcomingMovies(page).ToArray();
        }

        [HttpGet]
        [Route("search")]
        public ActionResult<IEnumerable<Movie>> SearchByName(string searchTerm, int page)
        {
            return service.SearchMoviesByName(searchTerm, page).ToArray();
        }

        [HttpGet]
        [Route("{id:int}")]
        public ActionResult<Movie> GetById(int id)
        {
            return service.GetById(id);
        }
    }
}