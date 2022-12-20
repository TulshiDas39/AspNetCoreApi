using AspNetCoreApi.Core.Dtos;
using AspNetCoreApi.Core.Models;
using AspNetCoreApi.Core.Types.Requests;

namespace AspNetCoreApi.Core.Interfaces.Services;

public interface IBookService:IBaseService<BookDto>
{
    Task<BookDto> UpdateBook(UpdateBookPayload payload);
}