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
    public class CategoryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet("GetAllCategories")]
        public IActionResult GetAllCategories()
        {
            var allCategories = _unitOfWork.Category.GetAll();
            var usersReadDTO = _mapper.Map<List<GetCategoryDTO>>(allCategories);
            return Ok(usersReadDTO);
        }


        [HttpGet("GetCategoryById")]
        public IActionResult GetCategoryById(int id)
        {
            var category = _unitOfWork.Category.GerById(id);
            var usersReadDTO = _mapper.Map<GetCategoryDTO>(category);
            return Ok(usersReadDTO);
        }


        [HttpPost("AddCategory")]
        public IActionResult AddCategories(AddCategoryDTO categoryDTO)
        {
            var category = _mapper.Map<Category>(categoryDTO);

            _unitOfWork.Category.Add(category);
            _unitOfWork.Complete();
            return Ok();
        }



    }
}
