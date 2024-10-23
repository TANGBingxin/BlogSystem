using AutoMapper;
using BlogSystem.Ability.Docking.NewsApp.Dto;
using BlogSystem.Ability.Docking.UserApp.Dto;
using BlogSystem.Domain.AccountInfo;
using BlogSystem.Domain.NewsInfo;

namespace BlogSystemSystem.Ability
{
    public class BlogSystemProfile : Profile
    {
        public BlogSystemProfile()
        {
            CreateMap<User, LoginSuccessDto>();
            CreateMap<UserCreateDto, User>();
            CreateMap<News, NewsDto>();
        }
    }
}
