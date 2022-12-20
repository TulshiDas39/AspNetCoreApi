using AspNetCoreApi.Core.Dtos;
using AspNetCoreApi.Core.Exceptions;
using AspNetCoreApi.Core.Interfaces.Repositories;
using AspNetCoreApi.Core.Interfaces.Services;
using AspNetCoreApi.Core.Models;
using AspNetCoreApi.Core.Types.Requests;
using AutoMapper;

namespace AspNetCoreApi.Services;

public class BookService:BaseService<Book,BookDto>,IBookService
{
    private readonly IBookRepository _repo;

    public BookService(IBookRepository repo, IMapper mapper) : base(repo, mapper)
    {
        _repo = repo;
    }

    public async Task<BookDto> UpdateBook(UpdateBookPayload payload)
    {
        var book = await _repo.GetById(payload.Id);
        if (book is null)
            throw new CustomException("Book not found.");


        book.Name = payload.Name;
        book.Author = payload.Author;
        book.EditionNo = payload.EditionNo;

        await _repo.SaveChangesAsync();

        return _mapper.Map<BookDto>(book);
    }
}