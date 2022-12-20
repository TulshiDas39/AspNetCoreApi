using AspNetCoreApi.Core.Interfaces.Repositories;
using AspNetCoreApi.Core.Models;
using AspNetCoreApi.Repositories.Context;

namespace AspNetCoreApi.Repositories;

public class BookRepository:BaseRepository<Book>,IBookRepository
{
    public BookRepository(AppDbContext context) : base(context)
    {
    }
}