using AutoMapper;
using CreateUserAPI.Data;
using CreateUserAPI.Data.Dtos;
using CreateUserAPI.Dtos;
using CreateUserAPI.Model;
using CreateUserAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CreateUserAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserReadOnlyRepository _readOnly;
        private readonly IUserWriteOnlyRepository _writeOnly;
        public UserController(IUserReadOnlyRepository readOnly, IUserWriteOnlyRepository writeOnly)
        {
           _readOnly = readOnly;
            _writeOnly = writeOnly;         
        }
        [HttpPost]
        public IActionResult CreateUser([FromBody] CreateUserDto userDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            UserResponseDto userResponse = _writeOnly.CreateUserRepository(userDto); 
            return Ok(userResponse);
        }
        [HttpGet]
        public IEnumerable<UserResponseDto> GetUsers()
        {
            var users = _readOnly.GetUsers();   
            return users;   
        }
    }
}