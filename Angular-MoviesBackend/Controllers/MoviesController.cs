using BAL.Models;
using DAL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Angular_MoviesBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public MoviesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("GetAllMovies")]
        public IActionResult GetAllMovies()
        {
            var allMovies = _unitOfWork.Movies.GetAll();
            return Ok(allMovies);
        }


        [HttpPost("AddMovie")]
        public IActionResult AddMovie(Movies movie)
        {
           _unitOfWork.Movies.Add(movie);
            _unitOfWork.Complete();
            return Ok();
        }

        [HttpGet("GetPopularMovies")]
        public IActionResult GetPopularMovies([FromQuery] int count)
        {
            var popularMovies = _unitOfWork.Movies.GetPopularMovies(count);
            return Ok(popularMovies);
        }

    }
}
