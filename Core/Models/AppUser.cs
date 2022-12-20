using Microsoft.AspNetCore.Identity;

namespace AspNetCoreApi.Core.Models;

public class AppUser: IdentityUser
{
    public int Age { get; set; }
    public string FullName { get; set; }
}