using AutoMapper;
using SportsSubscriptionAPI.Data;
using SportsSubscriptionAPI.Models.Team;

namespace SportsSubscriptionAPI.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Team, CreateTeamDto>().ReverseMap();
        }
    }
}
