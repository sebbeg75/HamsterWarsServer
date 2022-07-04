using System.ComponentModel.DataAnnotations;
namespace DataAccess.Models;

public class Hamster
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is a required field")]
    [MinLength(2, ErrorMessage = "Name is a required field")]
    public string? Name { get; set; }

    [Range(1, 5, ErrorMessage = "Age between 1 and 5.")]
    public int Age { get; set; }

    [Required(ErrorMessage = "Favourite food is a required field")]
    [MinLength(3, ErrorMessage = "Favourite food is a required field")]
    public string? FavFood { get; set; }

    [Required(ErrorMessage = "Favourite thing is a required field")]
    [MinLength(3, ErrorMessage = "Favourite thing is a required field")]
    public string? Loves { get; set; }
    public string? ImgName { get; set; }
    public int Wins { get; set; } = 0;
    public int Losses { get; set; } = 0;
    public int Games { get; set; } = 0;
}
