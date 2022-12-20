using AspNetCoreApi.Core.Types;
using Core.Dtos;

namespace AspNetCoreApi.Core.Interfaces.Services;

public interface IAuthService
{
    Task<LoginResult> LoginAsync(LoginPayload request);
}