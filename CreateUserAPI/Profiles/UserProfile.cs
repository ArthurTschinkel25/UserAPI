using AutoMapper;
using CreateUserAPI.Data.Dtos;
using CreateUserAPI.Dtos;
using CreateUserAPI.Model;
using CreateUserAPI.Repository;

namespace CreateUserAPI.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<CreateUserDto, UserModel>();
            CreateMap<UserModel, UserResponseDto>();   
        }
    }
}
