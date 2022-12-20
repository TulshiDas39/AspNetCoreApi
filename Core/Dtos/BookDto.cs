using AspNetCoreApi.Core.Interfaces.Common;
using AspNetCoreApi.Core.Models;

namespace AspNetCoreApi.Core.Dtos;

public class BookDto:BaseDto,IMapFrom<Book>
{
    public string Name { get; set; }
    public string Author { get; set; }
    public int EditionNo { get; set; }
}