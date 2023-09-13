using FluentValidation;
using FluentValidation.Results;
using Jarvis.DTOs;
using Jarvis.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using Jarvis.Utils;

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
    [HttpPost("authenticate")]
    public async Task<IActionResult> Authenticate(AuthenticateRequest model)
    {
        //var response = _userService.Authenticate(model);
        //if (response == null)
        //{
        //    return BadRequest(new { message = "Username or password is incorrect" });
        //}
        //else
        //{
        //    response.Token = _jwtUtils.GenerateJwtToken(response);
        //}

        //return Ok(response);
        ValidationResult result = await _validator.ValidateAsync(model);
        if (result.IsValid == false)
        {
            var errors = result.ToDto();
            return Problem();
        }
        var user = _userService.GetUser(model!.Username!, model!.Password!);
        if(user == null) 
        { 
            return Problem();
        }
        else
        {
            var token = _jwtUtils.GenerateJwtToken(user);
            return Ok(token);
        }

    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var users = _userService.GetAll();
        return Ok(users);
    }

    

}
