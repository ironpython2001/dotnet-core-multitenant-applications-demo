using FluentValidation;
using FluentValidation.Results;
using Jarvis.DTOs;
using Jarvis.Services;
using Jarvis.Utils;
using Microsoft.AspNetCore.Mvc;

namespace Jarvis.WebApi.Controllers;

[ApiController]
[Authorize]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private IValidator<AuthenticateRequest> _validator;
    private IUserService _userService;
    private readonly IJwtUtils _jwtUtils;

    public UsersController(IValidator<AuthenticateRequest> validator, IUserService userService, IJwtUtils jwtUtils)
    {
        _validator = validator;
        _userService = userService;
        _jwtUtils = jwtUtils;
    }

    [AllowAnonymous]
    [HttpPost("Authenticate")]
    public async Task<IActionResult> Authenticate(AuthenticateRequest model)
    {
        ValidationResult result = await _validator.ValidateAsync(model);
        if (result.IsValid is false)
        {
            var errors = result.ToDto();
            return Unauthorized(errors);
        }
        var user = _userService.GetUser(model!.Username!, model!.Password!);
        if (user is null)
        {
            return Unauthorized();
        }
        else
        {
            var response = new AuthenticateResponse(user, _jwtUtils.GenerateJwtToken(user));
            return Ok(response);
        }
    }

    [HttpGet]
    [Authorize]
    public IActionResult GetAll()
    {
        var users = _userService.GetAll();
        return Ok(users);
    }



}
