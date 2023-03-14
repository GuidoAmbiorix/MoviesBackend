using AutoMapper;
using BAL.Models;
using BAL.ViewModels.Movie;
using DAL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Angular_MoviesBackend.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MoviesController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet("GetAllMovies")]
        public IActionResult GetAllMovies()
        {
            var allMovies = _unitOfWork.Movies.GetAll();
            var usersReadDTO = _mapper.Map<List<GetMoviesDTO>>(allMovies);
            return Ok(usersReadDTO);
        }


        [HttpPost("AddMovie")]
        public IActionResult AddMovie(AddMovieDTO movieDTO)
        {
            var movie = _mapper.Map<Movies>(movieDTO);

            _unitOfWork.Movies.Add(movie);
            _unitOfWork.Complete();
            return Ok();
        }

        //[HttpGet("GetPopularMovies")]
        //public IActionResult GetPopularMovies([FromQuery] int count)
        //{
        //    var popularMovies = _unitOfWork.Movies.GetPopularMovies(count);
        //    return Ok(popularMovies);
        //}

    }
}
