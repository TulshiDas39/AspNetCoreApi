using AspNetCoreApi.Core.Interfaces.Services;
using AspNetCoreApi.Core.Types;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreApi.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class DataController:ApiController
{
    private readonly IDataService _data;

    public DataController(IDataService data)
    {
        _data = data;
    }

    [HttpGet("Seed")]
    public async Task<ActionResult<ApiResult<bool>>> SeedData()
    {
        var isSucces = await _data.SeedData();
        return OkResult(isSucces);
    }
}

