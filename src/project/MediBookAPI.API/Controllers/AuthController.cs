using Microsoft.AspNetCore.Mvc;
using MediBookAPI.Service.Concretes;

namespace MediBookAPI.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly JwtService _jwtService;

    public AuthController(JwtService jwtService)
    {
        _jwtService = jwtService;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        // Kullanıcı doğrulama işlemleri burada yapılacak
        // Örnek olarak, kullanıcı adı ve şifre kontrolü yapılabilir
        if (request.Username == "admin" && request.Password == "password")
        {
            var token = _jwtService.GenerateToken("1", request.Username);
            return Ok(new { token });
        }

        return Unauthorized();
    }
}

public class LoginRequest
{
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
} 