using CreateUserAPI.Data.Dtos;

namespace CreateUserAPI.Repository
{
    public interface IUserReadOnlyRepository
    {
        public IEnumerable<UserResponseDto> GetUsers();
    }
}
