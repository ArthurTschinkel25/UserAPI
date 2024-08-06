using System.ComponentModel.DataAnnotations;

namespace CreateUserAPI.Data.Dtos
{
    public class UserResponseDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
       
        public string? Email { get; set; }
    }
}
