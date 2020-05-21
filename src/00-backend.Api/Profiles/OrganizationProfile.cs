using AutoMapper;
using backend.Api.Models;
using backend.Domain.Entities;

namespace backend.Api.Profiles
{
    public class OrganizationProfile : Profile
    {
        public OrganizationProfile()
        {
            CreateMap<UserModel, User>();
            CreateMap<UserCreateModel, User>();
            CreateMap<User, UserModel>();
        }   
    }
}