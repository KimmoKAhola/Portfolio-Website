using AutoMapper;
using DataAccessLayer.Models;
using ProjectAPI.Models;

namespace ProjectAPI.Infrastructure.AutomapperConfigurations;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<GithubProject, GithubProjectViewModel>().ReverseMap();
    }
}
