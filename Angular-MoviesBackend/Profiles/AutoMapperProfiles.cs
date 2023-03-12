using AutoMapper;
using BAL.Models;
using BAL.ViewModels.Movie;

namespace Angular_MoviesBackend.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Movies,AddMovieDTO>().ReverseMap();
            CreateMap<Movies, GetMoviesDTO>().ReverseMap();


        }
    }
}
