using System.ComponentModel.DataAnnotations;

namespace AspNetCoreApi.Core.Types.Requests;

public class UpdateBookPayload
{
    [Required]
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    [Required]
    public string Author { get; set; }
    public int EditionNo { get; set; }
}