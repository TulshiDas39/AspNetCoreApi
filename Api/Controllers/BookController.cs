using AspNetCoreApi.Core.Dtos;
using AspNetCoreApi.Core.Interfaces.Services;
using AspNetCoreApi.Core.Types;
using AspNetCoreApi.Core.Types.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace AspNetCoreApi.Web.Controllers;

[ApiController]
[Route("[controller]")]
[Authorize]
public class BookController:ApiController
{
    private readonly IBookService _book;

    public BookController(IBookService book)
    {
        _book = book;
    }

    [AllowAnonymous]
    [HttpGet("all")]
    public async Task<ActionResult<ApiResult<List<BookDto>>>> GetAll()
    {
        Log.Information("Getting books");

        var books = await _book.GetAll();
        Log.Information($"Total books:{books.Count}");
        return OkResult(books);
    }

    [HttpPost]
    public async Task<ActionResult<ApiResult<BookDto>>> Create(BookDto payload)
    {
        var book = await _book.Create(payload);
        return OkResult(book);
    }

    [HttpPut]
    public async Task<ActionResult<ApiResult<BookDto>>> Update(UpdateBookPayload payload)
    {
        var book = await _book.UpdateBook(payload);
        return OkResult(book);
    }

    [HttpDelete("byId/{id}")]
    public async Task<ActionResult<ApiResult<bool>>> Delete(int id)
    {
        await _book.Delete(id);
        return OkResult(true);
    }
}