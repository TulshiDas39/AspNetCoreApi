using Microsoft.AspNetCore.Identity;

namespace AspNetCoreApi.Core.Models;

public class AppRole:IdentityRole
{
    public string Code { get; set; }
}