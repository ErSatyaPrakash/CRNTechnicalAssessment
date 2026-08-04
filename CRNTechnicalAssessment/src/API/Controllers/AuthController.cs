using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class AuthController : ControllerBase
    {

        private readonly IJwtService _jwtService;

        public AuthController(IJwtService jwtService)
        {
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginDto dto)
        {
            if (dto.Username == "admin" && dto.Password == "123456")
            {
                var token = _jwtService.GenerateToken(dto.Username);

                return Ok(new
                {
                    Token = token
                });
            }

            return Unauthorized("Invalid credentials");
        }
    }
}