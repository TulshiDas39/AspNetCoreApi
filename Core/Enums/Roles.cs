using System.ComponentModel;

namespace AspNetCoreApi.Core.Enums;

public enum Roles
{
    [Description("Admin")]
    Admin,

    [Description("User")]
    User
}