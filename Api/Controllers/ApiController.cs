using AspNetCoreApi.Core.Types;
using AspNetCoreApi.Core.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreApi.Web.Controllers;

public class ApiController : ControllerBase
{
    protected ActionResult<ApiResult<T>> OkResult<T>(T data)
    {
        var result = new ApiResult<T>(data);
        return Ok(result);
    }

    protected ActionResult<ApiResult<object>> Error(object error,string message)
    {
        var result = new Utility().GetErrorResponse(error,message);
        return BadRequest(result);
    }
}
