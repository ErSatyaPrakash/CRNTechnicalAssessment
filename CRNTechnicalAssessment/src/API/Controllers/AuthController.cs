using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    //[ApiVersion("1.0")]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {

        private readonly IJwtService _jwtService;

        public AuthController(IJwtService jwtService)
        {
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult Login([FromBody] LoginDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); 
            }

            if (dto.Username == "admin" && dto.Password == "123456")
            {
                var token = _jwtService.GenerateToken(dto.Username);

                return Ok(new
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Login successful",
                    Token = token
                });
            }

            return Unauthorized(new
            {
                StatusCode = StatusCodes.Status401Unauthorized,
                Message = "Invalid username or password"
            });
        }
    }
}