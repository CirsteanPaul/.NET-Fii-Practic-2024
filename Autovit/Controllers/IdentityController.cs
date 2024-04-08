using System.ComponentModel.DataAnnotations;
using Autovit.Mappers;
using Autovit.Models.Identity;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Services.Features.Identity;
using Services.Features.Identity.DTOs;

namespace Autovit.Controllers;

[ApiController]
[Route("api/identity")]
public sealed class IdentityController : ControllerBase
{
    private readonly IIdentityService _identityService;

    public IdentityController(IIdentityService identityService)
    {
        _identityService = identityService;
    }
    
    [HttpPost]
    public ActionResult Login(string username, string password)
    {
        var token = _identityService.Login(username, password);

        return Ok(token);
    }
    
    [HttpPost("register")]
    public ActionResult Register(IdentityRegisterRequest request)
    {
        _identityService.Register(request.ToDto());

        return Ok();
    }
}