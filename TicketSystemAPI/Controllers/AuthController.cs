using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TicketSystemAPI.DbContext;
using TicketSystemAPI.Models;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly TicketDbContext _context;

    public AuthController(TicketDbContext context)
    {
        _context = context;
    }

    [HttpPost("login")]
    public IActionResult Login(LoginModel model)
    {
        var user = _context.Users
            .FirstOrDefault(x =>
                x.Username == model.Username &&
                x.Password == model.Password);

        if (user == null)
            return BadRequest("Invalid login");

        return Ok(user);
    }
}