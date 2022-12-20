using AspNetCoreApi.Core.Interfaces.Services;
using AspNetCoreApi.Core.Types;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreApi.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController:ApiController
{
    private readonly IAuthService _auth;
    public AuthController(IAuthService auth)
    {
        _auth = auth;
    }

    [HttpPost]
    public async Task<ActionResult<ApiResult<LoginResult>>> Login(LoginPayload payload)
    {
        var result = await _auth.LoginAsync(payload);
        return OkResult(result);
    }

}