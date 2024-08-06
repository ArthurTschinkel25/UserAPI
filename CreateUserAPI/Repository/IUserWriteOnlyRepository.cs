using CreateUserAPI.Data.Dtos;
using CreateUserAPI.Dtos;

namespace CreateUserAPI.Repository
{
    public interface IUserWriteOnlyRepository
    {
        public UserResponseDto CreateUserRepository(CreateUserDto createUser);
    }
}
