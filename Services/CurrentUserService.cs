﻿using System.Security.Claims;
using Core.Interfaces;
using Microsoft.AspNetCore.Http;

namespace AspNetCoreApi.Services;

public class CurrentUserService:ICurrentUserService
{
    public CurrentUserService(IHttpContextAccessor httpContextAccessor)
    {
        UserId = httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
        UserName = httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.Name);
        Email = httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.Email);
        Role = httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.Role) ?? httpContextAccessor.HttpContext?.User.FindFirstValue("roles");
    }

    public string UserId { get; }
    public string UserName { get; }
    public string Email { get; }
    public string Role { get; }
}