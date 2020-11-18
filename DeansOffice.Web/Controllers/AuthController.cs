using DeansOffice.Domain.Models;
using DeansOffice.Logic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using DeansOffice.Logic.DTOs;

namespace DeansOffice.Web.Controllers
{
    [Route("api/Auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;
        private readonly IConfiguration _config;

        public AuthController(IAuthRepository authRepository, IConfiguration configuration)
        {
            _authRepository = authRepository;
            _config = configuration;
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody]UserRegisterDTO userRegisterDTO)
        {
            userRegisterDTO.Login = userRegisterDTO.Login.ToLower();

            if (_authRepository.UserExists(userRegisterDTO.Login))
                return BadRequest("Username already exists!");

            var studentToCreate = new User
            {
                Login = userRegisterDTO.Login,
                RegisteredDate = DateTime.Now,
                Role = "Student",
            };

            var createdStudent = _authRepository.Register(studentToCreate, userRegisterDTO.Password);
            return StatusCode(201);
        }

        [HttpPost("login")]
        public IActionResult Login(UserLoginDTO userLoginDTO)
        {
            var user = _authRepository.Login(userLoginDTO.Login.ToLower(), userLoginDTO.Password);

            if (user == null) return Unauthorized();

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier , user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Login),
                new Claim(ClaimTypes.Role, user.Role)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("AppSettings:Token").Value));

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddHours(1),
                SigningCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return Ok(new
            {
                token = tokenHandler.WriteToken(token)
            });
        }
    }
}