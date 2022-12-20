using Core.Models;

namespace AspNetCoreApi.Core.Models;

public class Book:BaseModel
{
    public string Name { get; set; }
    public string Author { get; set; }
    public int EditionNo { get; set; }
}