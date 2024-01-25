using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Onion.API.InterfaceServices;


namespace Onion.API;

[ApiController]
[Route("[controller]")]
[AllowAnonymous]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    public UserController(IUserService userService)
    {
        _userService = userService;
    }
    public IActionResult Login([FromBody] object dataLogin)
    {
        if(!ModelState.IsValid)
        {
            return BadRequest(ModelState.Select(item => item.Value.Errors).FirstOrDefault());
        }
        return Ok("dsadsadsa");
    }
}
