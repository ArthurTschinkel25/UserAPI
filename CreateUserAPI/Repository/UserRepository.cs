using AutoMapper;
using CreateUserAPI.Data;
using CreateUserAPI.Data.Dtos;
using CreateUserAPI.Dtos;
using CreateUserAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CreateUserAPI.Repository
{
    public class UserRepository : IUserWriteOnlyRepository, IUserReadOnlyRepository
    {
        private readonly BaseContext _baseContext;
        private IMapper _mapper;
        public UserRepository(BaseContext baseContext, IMapper mapper)
        {
            _baseContext = baseContext;
            _mapper = mapper;
        }
        public UserResponseDto CreateUserRepository(CreateUserDto createUser)
        {
            UserModel userModel = _mapper.Map<UserModel>(createUser);
            _baseContext.Users.Add(userModel);
            _baseContext.SaveChanges();
            return _mapper.Map<UserResponseDto>(userModel);
        }
        public IEnumerable<UserResponseDto> GetUsers()
        {
            var users = _baseContext.Users;
            return _mapper.Map<IEnumerable<UserResponseDto>>(users);    
        }
    }
}
